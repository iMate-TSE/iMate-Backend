using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services
{
    public class MoodService : BaseRepository
    {
        // Pass the context to the BaseRepo
        public MoodService(DataContext ctx) : base(ctx)
        {

        }

        // Defining all the database calls for the mood controller

        public async Task<IEnumerable<PadRanges>> GetPADDictionary()
        {
            return await _context.PadRanges.ToListAsync();
        }
    }
}