using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace iMate.API.Services
{
    public class SettingsService(DataContext ctx) : BaseRepository(ctx)
    {


        public User? GetUser(string username)
        {
            
            var queryUsers =
                     from user in _context.User
                     where user.userName == username
                     select user;

           return  queryUsers.SingleOrDefault(); ;
        }
        
        public User? GetUser(int id)
        {
            
            var queryUsers =
                from user in _context.User
                where user.userID == id
                select user;

            return  queryUsers.SingleOrDefault(); ;
        }

        public int GetTokenId(string token)
        {
            var query =
                from authToken in _context.AuthTokens
                where authToken.token == token
                select authToken.userID;
            return query.SingleOrDefault();
        }

        public async Task LogOut(User? user)
        {
            var queryTokens =  
                from token in _context.AuthTokens
                where token.userID == user.userID
                select token;

            AuthTokens? authToken =  await queryTokens.FirstOrDefaultAsync();

            if ( authToken != null)
            {
                _context.AuthTokens.Remove(authToken);
                _context.SaveChanges();
            }

        }

        public async Task<string?> GetUsername(string token)
        {
            var queryTokens =
                from authtoken in _context.AuthTokens
                where authtoken.token == token
                select authtoken;

            AuthTokens? authTokens = queryTokens.SingleOrDefault();

            if (authTokens != null)
            {
                var queryUsers =
                    from user in _context.User
                    where user.userID == authTokens.userID
                    select user;

                User? user1 = await queryUsers.SingleOrDefaultAsync();
                if (user1 != null)
                {
                    return user1.userName;
                }

             }
            
            return "404";

        }

        public async void CreateBaseSettings(User? user) 
        {
            Settings userSettings = new Settings(user);
            await _context.Settings.AddAsync(userSettings);
            _context.SaveChanges();
        }

        public Settings? GetSettings(User? user) 
        {
            var settings =
                from setting in _context.Settings
                where (setting.user).userID == user.userID
                select setting;

            return settings.SingleOrDefault();

        }

        public void Update(User user, bool soundEffects, bool reducedMotion, bool motivation, bool practice, bool scheduling, string? reminder) 
        {
            var settings =
               from set in _context.Settings
               where (set.user).userID == user.userID
               select set;

            Settings? settings1 = settings.SingleOrDefault();

            if (settings1  != null) 
            { 
                settings1.soundEffects = soundEffects;
                settings1.reducedMotion = reducedMotion;
                settings1.motivationalMessages = motivation;
                settings1.practiceReminder = practice;
                settings1.smartScheduling = scheduling;
                settings1.reminderTime = reminder;
            }

            _context.SaveChanges();
        }

    }
}