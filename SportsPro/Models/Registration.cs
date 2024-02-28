using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsPro.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Registration : ControllerBase
    {
        // GET: api/<Registration>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Registration>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Registration>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Registration>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Registration>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
