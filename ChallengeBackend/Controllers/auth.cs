using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        // GET: api/<Auth/>
        [HttpGet]
        public IEnumerable<string> Login()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AutenticationControllers>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
