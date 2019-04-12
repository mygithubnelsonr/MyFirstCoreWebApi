using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get([FromQuery] int id, string query)
        {
            return $"value={id} query={query}";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Value value)
        {
            if(!ModelState.IsValid)
            {
                throw new InvalidOperationException("invalid");
            }

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Value
    {
        public int Id { get; set; }

        [MinLength(4)]
        public string Text { get; set; }
    }
}
