using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services;

public class ProfileService : BaseRepository
{
    public ProfileService(DataContext ctx) : base(ctx)
    {
        
    }

    public async Task<User?> GetProfile(int ID)
    {
        return await (
            from Profile in _context.User
            where Profile.userID == ID
            select Profile
            ).SingleOrDefaultAsync();
    }

    public async Task<int> GetUserID(String Token)
    {
        return await (
            from AuthToken in _context.AuthTokens
            where AuthToken.token == Token
            select AuthToken.userID
            ).SingleOrDefaultAsync();
    }

    public async Task<int> GetCredits(int ID)
    {
        var queryCredits =
            from user in _context.User
            where user.userID == ID
            select user;

        User? user1 = await queryCredits.SingleOrDefaultAsync();
        if (user1 == null) { return -1; }
        return user1.credits;
    }

    public async Task<int> GetStreak(int ID)
    {
        var queryStreak =
            from User in _context.User
            where User.userID == ID
            select User;
        User? user = await queryStreak.SingleOrDefaultAsync();
        if (user == null)
        {
            return -1;
        }

        return user.streak;

    }
    

    public async Task SetCredits(int ID, int increment)
    {
        var queryCredits =
            from user in _context.User
            where user.userID == ID
            select user;

        User? user1 = await queryCredits.SingleOrDefaultAsync();
        if (user1 == null) { return; }
        user1.credits = (user1.credits + increment);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProfile(int ID, int age, string gender, string username, string fullname, string avatarPath)
    {
        User? profile = await GetProfile(ID);

        if (profile != null)
        {
            profile.age = age;
            profile.gender = gender;
            profile.userName = username;
            profile.fullName = fullname;
            profile.avatarPath = avatarPath;
            
            await _context.SaveChangesAsync();
        }
    }
}