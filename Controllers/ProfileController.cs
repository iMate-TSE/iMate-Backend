using iMate.API.Data.Models;
using iMate.API.Data.RequestModels;
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
            User? user = await _service.GetProfile(UserID);
            return Ok(user);
        }
        catch (Exception e)
        {
           return NotFound();
        }
    }

    [HttpPut]
    public async Task<IActionResult> updateProfile([FromBody] ProfileRequest req)
    {
        try
        {
            int id = await _service.GetUserID(req.token);
            await _service.UpdateProfile(id, req.age, req.gender, req.username, req.fullname, req.avatarPath);
        }
        catch (Exception e)
        {
            throw e;
            return BadRequest(e);
        }

        return Ok();
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

    [HttpPut]
    [Route("setCredits")]
    public async Task<IActionResult> setCredits([FromBody] CreditsRequest req)
    {
        if (!ModelState.IsValid)
        {
            // model state is a built-in thing that validates the data in the form body
            return BadRequest(ModelState);
        }

        string Token = req.token;
        int NewCredits =  int.Parse(req.points);

        try
        {
            int UserID = await _service.GetUserID(Token);
            await _service.SetCredits(UserID, NewCredits);
        }
        catch (Exception e)
        {
            return BadRequest();
        }

        return Ok();
    }
    
    [HttpGet]
    [Route("getStreak")]
    public async Task<IActionResult> getStreak(string Token)
    {
        try 
        {
            int UserID = await _service.GetUserID(Token);
            int streak = await _service.GetStreak(UserID);
            return Ok(streak);
        }
        catch (Exception e) 
        {
            return NotFound();
        }
    }
}