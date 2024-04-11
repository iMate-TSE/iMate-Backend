using iMate.API.Data.Models;
using iMate.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using static BCrypt.Net.BCrypt;

namespace iMate.API.Controllers
{
  
    [ApiController]
    public class LoginController : ControllerBaseExtended
    {
        private readonly LoginService _service;

        public LoginController(LoginService service)
        {
            _service = service;
        }


        [HttpPost]
        [Route("api/v1/[controller]/SignUp")]
        public void SignUpUser(string username, string password)
        {
            _service.SignUp(username, password);
        }

        [HttpPost]
        [Route("api/v1/[controller]/Login")]
        public async Task<IActionResult> LoginUser (string username, string password) 
        {
            User user = _service.Login(username);
            if (Verify(password, user.encryptedPassword))
             {
                string token = _service.GetToken(user.userName, user.encryptedPassword);
                AuthTokens authtoken = new AuthTokens(user.userID, token);
                _service.SaveToken(authtoken);
                return Ok(token);
             }
            
            return NotFound();
        }

    }
}