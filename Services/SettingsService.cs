using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace iMate.API.Services
{
    public class SettingsService(DataContext ctx) : BaseRepository(ctx)
    {


        public User GetUser(string username)
        {
            var queryUsers =
                from user in _context.User
                where user.userName == username
                select user;

            return queryUsers.FirstOrDefault();
        }

        public async void LogOut(User user)
        {

            var queryTokens =
                from token in _context.AuthTokens
                where token.userID == user.userID
                select token;

            AuthTokens authToken = queryTokens.FirstOrDefault();

            _context.AuthTokens.Remove(authToken);
            _context.SaveChanges();

        }

        public string GetUsername(string token)
        {
            var queryTokens =
                from authtoken in _context.AuthTokens
                where authtoken.token == token
                select authtoken;

            AuthTokens authTokens = queryTokens.FirstOrDefault();

            var queryUsers =
                from user in _context.User
                where user.userID == authTokens.userID
                select user;

            User user1 = queryUsers.FirstOrDefault();

            return user1.userName;

        }

        public async void CreateBaseSettings(User user) 
        {
            Settings userSettings = new Settings(user);
            await _context.Settings.AddAsync(userSettings);
            _context.SaveChanges();
        }

        public Settings GetSettings(User user) 
        {
            var settings =
                from setting in _context.Settings
                where (setting.user).userID == user.userID
                select setting;

            return settings.FirstOrDefault();

        }

        public async void Update(User user, bool soundEffects, bool reducedMotion, bool motivation, bool practice, bool scheduling, string? reminder) 
        {
            var settings =
               from setting in _context.Settings
               where (setting.user).userID == user.userID
               select setting;

            foreach (var setting in settings) {
                setting.soundEffects = soundEffects;
                setting.reducedMotion = reducedMotion;
                setting.motivationalMessages = motivation;
                setting.practiceReminder = practice;
                setting.smartScheduling = scheduling;
                setting.reminderTime = reminder;
            }

            _context.SaveChanges();
        }

    }
}