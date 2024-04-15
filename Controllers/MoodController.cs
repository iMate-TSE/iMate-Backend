using iMate.API.Data.Models;
using iMate.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace iMate.API.Controllers
{
    // Extending the class to use a custom result type
    [DefaultStatusCode(DefaultStatusCode)]
    public class UnimplementedResult() : StatusCodeResult(DefaultStatusCode)
    {
        private const int DefaultStatusCode = StatusCodes.Status501NotImplemented;
    }

    // Adding the new exception to the class
    public class ControllerBaseExtended : ControllerBase
    {
        [NonAction]
        public virtual UnimplementedResult Unimplemented() 
            => new UnimplementedResult();
    }


    [ApiController]
    public class MoodController : ControllerBaseExtended
    {
        private readonly MoodService _service;
        
        // Inject the mood service

        public MoodController(MoodService service)
        {
            _service = service;
        }

        // POST route for mood calculation 

        [HttpPost]
        [Route("api/v1/[controller]/")]
        public async Task<string> calculateMood(int Pleasure, int Arousal, int Dominance)
        {
            // http://localhost:5137/api/v1/Mood?Pleasure=2&Arousal=0&Dominance=5

            // get the ranges from the database
            List<PadRanges> padRanges = (await _service.GetPADDictionary()).ToList();

            EmotionClassifier classifier = new EmotionClassifier(padRanges);

            string mood = classifier.ClassifyEmotionByPAD(Pleasure, Arousal, Dominance);

            return mood;
        }

        [HttpGet]
        [Route("api/v1/[controller]/generateQuestions")]
        public async Task<IActionResult> generateQuestions(string moodCategory)
        {
            IEnumerable<FormQuestions> questions = await _service.GetFormQuestions(moodCategory);

            if (questions == null)
            {
                return NotFound();
            } 
            return Ok(questions);

        }
    }
}
