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
        [HttpPost]
        public string calculateMood(int Pleasure, int Arousal, int Dominance)
        {
            MoodService EmotionClassifier = new MoodService();

            string mood = EmotionClassifier.ComputePAD(Pleasure, Arousal, Dominance);

            return mood;
        }
        
    }
}
