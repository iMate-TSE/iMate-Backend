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
        public string LogOut(string username)
        {
            User user = _service.GetUser(username);
            if (user != null)
            {
                _service.LogOut(user);
                return $"Log Out Successful for {user.userName}";
            }
            
            return "Failed to find User";

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
        public string GetUserSettings(string username) 
        {
            User user = _service.GetUser(username);
            if (user != null) 
            {
                Settings settings = _service.GetSettings(user);
                string _settings = $"Settings for {(settings.user).userName}:\n";
                _settings += $"Sound effects: {settings.soundEffects}\n";
                _settings += $"Reduced Motion: {settings.reducedMotion}\n";
                _settings += $"Motivational Messages: {settings.motivationalMessages}\n";
                _settings += $"Practice Reminder: {settings.practiceReminder}\n";
                _settings += $"Smart Scheduling: {settings.smartScheduling}\n";
                _settings += $"Reminder Time: {settings.reminderTime}\n";

                return _settings ;

            }

            return "failed to retrieve settings";

        }

        [HttpPost]
        [Route("api/v1/[controller]/UpdateUserSettings")]
        public string UpdateSettings(string username, bool soundEffects, bool reducedMotion, bool motivation, bool practice, bool scheduling, string? reminder)
        {
            User user = _service.GetUser(username);
            if (user != null)
            {
                _service.Update(user, soundEffects, reducedMotion, motivation, practice, scheduling, reminder);
                return GetUserSettings(username);
            }
            return "failed to update settings";
        }
    }
}
