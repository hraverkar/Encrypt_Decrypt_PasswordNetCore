using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestRestWebApi.Model;

namespace TestRestWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        private readonly IUserService _userService;
        public AuthsController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            var existingUser = _userService.GetUser(user.UserId);
            if (existingUser != null)
            {
                return Ok("User Already Present in database");
            }
            var opStat = _userService.SaveUser(user);
            return Ok(opStat);
        }

        [HttpGet]
        public IActionResult Get(string userId)
        {
            var user = _userService.GetUser(userId);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
