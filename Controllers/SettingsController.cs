using iMate.API.Data.Models;
using iMate.API.Data.RequestModels;
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
        public async Task LogOut([FromBody] LogoutRequest settingsRequestData)
        {
            if (!ModelState.IsValid)
            {

            }
            else
            {
                string token = settingsRequestData.Token;
                if (token != null)
                {
                    int id = _service.GetTokenId(token);
                    User? user = _service.GetUser(id);
                    if (user != null)
                    {
                        await _service.LogOut(user);
                    }
                }
            }
        }

        [HttpPost]
        [Route("api/v1/[controller]/CreateDefaultSettings")]
        public async void CreateDefaultSettings([FromBody] SettingsRequest settingsRequestData)
        {
            if (!ModelState.IsValid)
            {

            }
            else
            {
                string username = settingsRequestData.Username;
                if (username != null)
                {
                    User? user =  _service.GetUser(username);
                    if (user != null)
                    {
                         _service.CreateBaseSettings(user);
                    }
                }
            }
        }

        [HttpGet]
        [Route("api/v1/[controller]/GetUserSettings")]
        public Dictionary<string, string> GetUserSettings(string username) 
        {
            User? user = _service.GetUser(username);
            if (user != null)
            {
                Settings? settings =  _service.GetSettings(user);
                if (settings != null) {
                    Dictionary<string, string> _settings = new Dictionary<string, string>()
                    {
                        ["sound"] = (settings.soundEffects).ToString(),
                        ["motion"] = (settings.reducedMotion).ToString(),
                        ["motivation"] = (settings.motivationalMessages).ToString(),
                        ["reminder"] = (settings.practiceReminder).ToString(),
                        ["scheduling"] = (settings.smartScheduling).ToString(),
                        ["time"] = settings.reminderTime

                    };
                return _settings;
            };

                return new Dictionary<string, string>() ;

            }

            return new Dictionary<string, string>();

        }

        [HttpPost]
        [Route("api/v1/[controller]/UpdateUserSettings")]
        public async void UpdateSettings([FromBody] SettingsRequest settingsRequestData)
        {
            if (!ModelState.IsValid)
            {

            }
            else
            {
                string username = settingsRequestData.Username;
                bool soundEffects = settingsRequestData.SoundEffects;
                bool reducedMotion = settingsRequestData.ReducedMotion;
                bool motivation = settingsRequestData.Motivation;
                bool practice = settingsRequestData.Practice;
                bool scheduling = settingsRequestData.Scheduling;
                string? reminder = settingsRequestData.Reminder;

                if (username != null)
                {
                    User? user = _service.GetUser(username);
                    if (user != null)
                    {
                        _service.Update(user, soundEffects, reducedMotion, motivation, practice, scheduling, reminder);
                    }
                }
            }
        }

        [HttpGet]
        [Route("api/v1/[controller]/GetUsername")]
        public async Task<string?> GetUsername(string token) 
        {
            return await _service.GetUsername(token);
        }


    }
}
