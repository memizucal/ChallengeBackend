using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChallengeBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class characters : ControllerBase
    {
        // GET: api/<characters>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<characters>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<characters>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<characters>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<characters>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
