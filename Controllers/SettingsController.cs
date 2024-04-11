using iMate.API.Data.Models;
using iMate.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace iMate.API.Controllers
{

    [ApiController]
    
    public class SettingsController : ControllerBaseExtended
    {
        private readonly SettingsService _service;

        public SettingsController(SettingsService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("api/v1/[controller]/LogOut")]
        public void LogOut(string username)
        {
            User user = _service.GetUser(username);
            if (user != null)
            {
                _service.LogOut(user);
            }

        }

        [HttpPost]
        [Route("api/v1/[controller]/CreateDefaultSettings")]
        public void CreateDefaultSettings(string username)
        {
            User user = _service.GetUser(username);
            if (user != null)
            {
                _service.CreateBaseSettings(user);
            }
        }

        [HttpGet]
        [Route("api/v1/[controller]/GetUserSettings")]
        public Dictionary<string, string> GetUserSettings(string username) 
        {
            User user = _service.GetUser(username);
            if (user != null)
            {
                Settings settings = _service.GetSettings(user);
                Dictionary<string, string> _settings = new Dictionary<string, string>() {
                    ["sound"] = (settings.soundEffects).ToString(),
                    ["motion"] = (settings.reducedMotion).ToString(),
                    ["motivation"] = (settings.motivationalMessages).ToString(),
                    ["reminder"] = (settings.practiceReminder).ToString(),
                    ["scheduling"] =(settings.smartScheduling).ToString(),
                    ["time"] = settings.reminderTime
            };

                return _settings ;

            }

            return new Dictionary<string, string>();

        }

        [HttpPost]
        [Route("api/v1/[controller]/UpdateUserSettings")]
        public void UpdateSettings(string username, bool soundEffects, bool reducedMotion, bool motivation, bool practice, bool scheduling, string? reminder)
        {
            User user = _service.GetUser(username);
            if (user != null)
            {
                _service.Update(user, soundEffects, reducedMotion, motivation, practice, scheduling, reminder);
            }
        }

        [HttpGet]
        [Route("api/v1/[controller]/GetUsername")]
        public string GetUsername(string token) 
        {
            return _service.GetUsername(token);
        }


    }
}
