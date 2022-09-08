using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/heroes")]
    public class HeroesController : Controller
    {
        public static List<SuperHero> heores = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Spiderman",
                FirstName = "Peter",
                LastName = "Parker",
                Age = 18,
                City = "New York"
            },
            new SuperHero
            {
                Id = 2,
                Name = "Ironman",
                FirstName = "Tony",
                LastName = "Stark",
                Age = 34,
                City = "Long Island"
            }
        };

        // GET: api/values
        [HttpGet]
        public ActionResult<List<SuperHero>> Get()
        {
            return Ok(heores);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<SuperHero> Get(int id)
        {
            var hero = heores.Find(h => h.Id == id);
            if(hero == null)
            {
                return NotFound("No se encontro superhero");
            }

            return Ok(hero);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<List<SuperHero>> Post(SuperHero hero)
        {
            heores.Add(hero);

            return Ok(heores);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var hero = heores.Find(h => h.Id == id);
            if(hero == null)
            {
                return NotFound("No se encontro superhero");
            }

            heores.Remove(hero);

            return Ok("Deleted");
        }
    }
}
