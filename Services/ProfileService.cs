using iMate.API.Data;
using iMate.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace iMate.API.Services;

public class ProfileService : BaseRepository
{
    public ProfileService(DataContext ctx) : base(ctx)
    {
        
    }

    public async Task<User> GetProfile(int ID)
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
}