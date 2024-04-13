using iMate.API.Data.Models;
using iMate.API.Data.RequestModels;
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
        [Route("api/v1/[controller]/Signup")]
        public void SignUp([FromBody] LoginRequest loginRequestData)
        {
            if (!ModelState.IsValid)
            {

            }
            else
            {
                string username = loginRequestData.Username;
                string password = loginRequestData.Password;
                if (username != null && password != null)
                {
                    _service.SignUp(username, password);
                }
            }
        }

        [HttpPost]
        [Route("api/v1/[controller]/Login")]
        public async Task<IActionResult> Login ([FromBody] LoginRequest loginRequestData) 
        {
            // We pass in the Form Data from the Request which is the JSON that is passed into the post request.
            // then we validate it 
            if (!ModelState.IsValid)
            {
                // model state is a built in thing that validates the data in the form body
                return BadRequest(ModelState);
            }

            string username = loginRequestData.Username;
            string password = loginRequestData.Password;
            
            // changed to below a little to handle null values
            User? user = await _service.Login(username);

            if (user == null) return NotFound();

            if (user.userName != null && user.encryptedPassword != null)
            {
                if (Verify(password, user.encryptedPassword))
                {
                    string token = _service.GetToken(user!.userName, user.encryptedPassword);
                    AuthTokens authtoken = new AuthTokens(user.userID, token);
                    _service.SaveToken(authtoken);
                    return Ok(token);
                }
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("api/v1/[controller]/ClearTokens")]
        public async Task<IActionResult> ClearTokens()
        {
            await _service.WipeTokens();
            return NoContent();
        }

    }
}