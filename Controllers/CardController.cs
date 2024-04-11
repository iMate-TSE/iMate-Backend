using iMate.API.Data.Models;
using iMate.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace iMate.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CardController : ControllerBase
    {
        protected readonly CardService _service;

        public CardController(CardService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<IEnumerable<TarotCards>> getCards(string mood)
        {
            return _service.FetchTasks(mood);
        }

    }
}
