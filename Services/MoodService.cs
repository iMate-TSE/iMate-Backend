using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services
{
    public class MoodService(DataContext ctx) : BaseRepository(ctx)
    {
        // Pass the context to the BaseRepo

        // Defining all the database calls for the mood controller

        public async Task<IEnumerable<PadRanges>> GetPADDictionary()
        {
            return await _context.PadRanges.ToListAsync();
        }

        public async Task<IEnumerable<FormQuestions>> GetFormQuestions(string category)
        {
            var query = await (
                from Question in _context.FormQuestions
                where Question.Category == category
                select Question).ToListAsync();
            
            return query;
        }
    }
}