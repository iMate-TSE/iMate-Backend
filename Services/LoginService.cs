using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static BCrypt.Net.BCrypt;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace iMate.API.Services
{
    public class LoginService(DataContext ctx) : BaseRepository(ctx)
    {

        public static string JWT(string username, string password)
        {
            string currentDateTime = DateTime.Now.ToString("ddMMyyyyHHmm");
            string plainText = username + password + currentDateTime;
            // Encode the string as a byte array using UTF-8 encoding
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            var inputHash = SHA256.HashData(plainTextBytes);
            return Convert.ToHexString(inputHash);
        }


        public async void SignUp( string username, string password)
        {
            string hashedPassword = HashPassword(password);

            User userObject = new User(username, hashedPassword);

            await _context.User.AddAsync(userObject);

            _context.SaveChanges();
        }


        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _context.User.ToArrayAsync();
        }

        
        public Task<User?> Login (string username)
        {
        
            var queryUsers =
                from user in _context.User
                where user.userName == username
                select user;

            return queryUsers.SingleOrDefaultAsync();

        }

        public string GetToken (string username, string password)
        {
            return JWT(username, password);
        }

        public async void SaveToken (AuthTokens token)
        {
            await _context.AuthTokens.AddAsync(token);
            _context.SaveChanges();
        }

        public async Task WipeTokens()
        {
            _context.AuthTokens.ToList().ForEach(Entity => _context.AuthTokens.Remove(Entity));
            await _context.SaveChangesAsync();
        }


    }
}