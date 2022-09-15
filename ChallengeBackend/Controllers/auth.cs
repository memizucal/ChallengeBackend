using Microsoft.AspNetCore.Mvc;

namespace ChallengeBackend.Controllers
{
    [Route("auth/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        
        [HttpPost]        
        public IActionResult Login(string user, string password)
        {
            return Ok(); //Token
        }

        
        [HttpPost()]
        public IActionResult Register(string user, string password)
        {
            return Ok(); // token
        }

        
    }
}
