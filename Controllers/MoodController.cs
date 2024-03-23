using iMate.API.Data.Models;
using iMate.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace iMate.API.Controllers
{
    // Extending the class to use a custom result type
    [DefaultStatusCode(DefaultStatusCode)]
    public class UnimplementedResult : StatusCodeResult
    {
        private const int DefaultStatusCode = StatusCodes.Status501NotImplemented;

        public UnimplementedResult() : base(DefaultStatusCode)
        {
   
        }
    }

    // Adding the new exception to the class
    public class ControllerBaseExtended : ControllerBase
    {
        [NonAction]
        public virtual UnimplementedResult Unimplemented() 
            => new UnimplementedResult();
    }


    [ApiController]
    [Route("api/v1/[controller]")]
    public class MoodController : ControllerBaseExtended
    {
        protected readonly MoodService _service;

        public MoodController(MoodService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<string> calculateMood(int Pleasure, int Arousal, int Dominance)
        {
            // http://localhost:5137/api/v1/Mood?Pleasure=2&Arousal=0&Dominance=5

            List<PadRanges> padRanges = (await _service.GetPADDictionary()).ToList();

            EmotionClassifier classifier = new EmotionClassifier(padRanges);

            string mood = classifier.ClassifyEmotionByPAD(Pleasure, Arousal, Dominance);

            return mood;
        }
    }
}
