using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dnxazureapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        // GET api/fruit
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "fruit1", "fruit2" };
        }

        // GET api/fruit/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "fruit#" + id;
        }

        // POST api/fruit
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            return $"{value} has been created";
        }

        // PUT api/fruit/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            return $"{id} with {value} has been updated";
        }

        // DELETE api/fruit/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return $"{id} has been deleted";
        }
    }
}