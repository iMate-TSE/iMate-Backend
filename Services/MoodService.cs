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
    
    public class MoodService(DataContext ctx, ILogger<MoodService> logger) : BaseRepository(ctx)
    {
        // Pass the context to the BaseRepo

        // Defining all the database calls for the mood controller

        public async Task<IEnumerable<PadRanges>> GetPADDictionary()
        {
            return await ctx.PadRanges.ToListAsync();
        }
        
        public async Task<int> GetUserID(String Token)
        {
            return await (
                from AuthToken in ctx.AuthTokens
                where AuthToken.token == Token
                select AuthToken.userID
            ).SingleOrDefaultAsync();
        }
        
        public async Task<IEnumerable<FormQuestions>> GetFormQuestions(string category)
        {
            var query = await (
                from Question in ctx.FormQuestions
                where Question.Category == category
                select Question).ToListAsync();
            
            return query;
        }

        public async Task<int> GetMoodID(string mood)
        {
            var query = await (
                from Moods in ctx.PadRanges
                where Moods.mood == mood
                select Moods.moodID).SingleOrDefaultAsync();
            return query;
        }

        public async Task SaveMoodEntry(string token, string mood)
        {
            int id = await GetUserID(token);
            int moodId = await GetMoodID(mood);

            MoodEntry entry = new MoodEntry(id, DateTime.Now, moodId);
            await ctx.MoodEntry.AddAsync(entry); 
            await ctx.SaveChangesAsync();
        }

        public async Task RemoveMoodEntry(int id)
        {
            var entry = await (
                from Entry in ctx.MoodEntry
                where Entry.Id == id
                select Entry
            ).FirstOrDefaultAsync();
            if (entry != null)
            {
                ctx.MoodEntry.Remove(entry);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task CheckAndUpdateStreak(string token)
        {
            int userID = await GetUserID(token);

            var lastMoodEntry = await (
                from Entry in ctx.MoodEntry
                orderby Entry.date
                select Entry
            ).Reverse().FirstOrDefaultAsync();
            
            
            var lastMoodLog = DateOnly.FromDateTime(lastMoodEntry.date);
            
            logger.LogInformation(lastMoodLog.ToString());
            logger.LogInformation(lastMoodLog.AddDays(1).ToString());
            logger.LogInformation(DateOnly.FromDateTime(DateTime.Now).ToString());
            logger.LogInformation((DateOnly.FromDateTime(DateTime.Now) == lastMoodLog.AddDays(1)).ToString());
            
            var user = await (
                from User in ctx.User
                where User.userID == userID
                select User
            ).SingleOrDefaultAsync();

            if (user != null)
            {
                if ((lastMoodLog.AddDays(1) == DateOnly.FromDateTime(DateTime.Now)) || user.streak == 0)
                {
                    user.streak += 1;
                    logger.LogInformation(user.streak.ToString());
                    await ctx.SaveChangesAsync();
                }
            }
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
                from Entry in ctx.MoodEntry
                where Entry.date >= startOfWeek && Entry.date <= endOfWeek && Entry.userID == id
                select Entry).ToListAsync();
            return query;
        }
    }
}