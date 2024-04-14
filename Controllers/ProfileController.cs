using iMate.API.Data.Models;
using iMate.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace iMate.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ProfileController : ControllerBase
{
    protected readonly ProfileService _service;

    public ProfileController(ProfileService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> getProfile(string Token)
    {
        try
        {
            int UserID = await _service.GetUserID(Token);
            User user = await _service.GetProfile(UserID);
            return Ok(user);
        }
        catch (Exception e)
        {
           return NotFound();
        }
    }

    [HttpGet]
    [Route("getCredits")]
    public async Task<IActionResult> getCredits(string Token)
    {
        try 
        {
            int UserID = await _service.GetUserID(Token);
            int credits = await _service.GetCredits(UserID);
            return Ok(credits);
        }
        catch (Exception e) 
        {
            return NotFound();
        }
    }

    [HttpPatch]
    public async Task setCredits(string Token, int NewCredits)
    {
        try {
            int UserID = await _service.GetUserID(Token);
            await _service.SetCredits(UserID, NewCredits);
        }
        catch (Exception e) { return; }
    }
}