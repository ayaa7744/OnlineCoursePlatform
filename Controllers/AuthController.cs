using Microsoft.AspNetCore.Mvc;
using OnlineCoursePlatform.Interfaces;
using OnlineCoursePlatform.Models;
using OnlineCoursePlatform.DTOs;
namespace OnlineCoursePlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto request)
        {
            if (await _authService.UserExists(request.Username))
                return BadRequest("Username is already taken.");

            var user = new User
            {
                Username = request.Username,
                Email = request.Email,
               
            };

            await _authService.Register(user, request.Password);
            return Ok("User registered successfully.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto request)
        {
            var token = await _authService.Login(request.Username, request.Password);
            if (token == null)
                return Unauthorized("Invalid username or password.");

            return Ok(new { token });
        }
    }
}
