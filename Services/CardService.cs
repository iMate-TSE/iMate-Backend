using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services
{
    public class CardService : BaseRepository
    {
        public CardService(DataContext ctx) : base(ctx)
        {

        }

        public async Task<IEnumerable<TarotCards>> FetchTasks(string mood)
        {
            return await (
                from TarotCards in _context.TarotCards 
                where TarotCards.targetMood.mood == mood 
                select TarotCards
                ).ToListAsync();
        }
    }
}