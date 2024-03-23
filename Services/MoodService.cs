using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services
{
    public class MoodService : BaseRepository
    {
        public MoodService(DataContext ctx) : base(ctx)
        {

        }

        public async Task<IEnumerable<PadRanges>> GetPADDictionary()
        {
            return await _context.PadRanges.ToListAsync();
        }
    }
}