using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
    
    public class MoodService(DataContext ctx) : BaseRepository(ctx)
    {
        // Pass the context to the BaseRepo

        // Defining all the database calls for the mood controller

        public async Task<IEnumerable<PadRanges>> GetPADDictionary()
        {
            return await _context.PadRanges.ToListAsync();
        }
        
        public async Task<int> GetUserID(String Token)
        {
            return await (
                from AuthToken in _context.AuthTokens
                where AuthToken.token == Token
                select AuthToken.userID
            ).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<FormQuestions>> GetFormQuestions(string category)
        {
            var query = await (
                from Question in _context.FormQuestions
                where Question.Category == category
                select Question).ToListAsync();
            
            return query;
        }

        public async Task<int> GetMoodID(string mood)
        {
            var query = await (
                from Moods in _context.PadRanges
                where Moods.mood == mood
                select Moods.moodID).SingleOrDefaultAsync();
            return query;
        }

        public async Task SaveMoodEntry(string token, string mood)
        {
            int id = await GetUserID(token);
            int moodId = await GetMoodID(mood);

            MoodEntry entry = new MoodEntry(id, DateTime.Now, moodId);
            await _context.MoodEntry.AddAsync(entry);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<MoodEntry>> GetJournalSummary(string token)
        {
            int id = await GetUserID(token);
            var now = DateTime.Now;
            // Calculate the start of the current week (Sunday)
            var startOfWeek = now.StartOfWeek(DayOfWeek.Sunday);
            // Calculate the end of the current week (Saturday) - Add 6 days to get Saturday
            var endOfWeek = startOfWeek.AddDays(6);

            var query = await (
                from Entry in _context.MoodEntry
                where Entry.date >= startOfWeek && Entry.date <= endOfWeek && Entry.userID == id
                select Entry).ToListAsync();
            return query;
        }
    }
}