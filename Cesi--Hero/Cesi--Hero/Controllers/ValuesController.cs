using Microsoft.AspNetCore.Mvc;
using Cesi__Hero.Model;
using Cesi__Hero.Services;

namespace Cesi__Hero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IHeroServices _heroServices;

        public ValuesController(IHeroServices heroServices)
        {
            _heroServices = heroServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hero>> GetAllHeroes()
        {
            var heroes = _heroServices.GetAllHero();
            if (heroes == null)
            {
                return NotFound("Heros non trouvés");
            }
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public ActionResult<Hero> GetHero(int id)
        {
            var hero = _heroServices.GetHero(id);
            if (hero == null)
                return NotFound("Hero non trouvé");

            return Ok(hero);
        }

        [HttpPost]
        public ActionResult<IEnumerable<Hero>> AddHero([FromBody] Hero hero)
        {
            var heroes = _heroServices.AddHero(hero);
            return Ok(heroes);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Hero>> UpdateHero(int id, [FromBody] Hero hero)
        {
            var updatedHeroes = _heroServices.UpdateHero(id, hero);
            return Ok(updatedHeroes);
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Hero>> DeleteHero(int id)
        {
            var heroes = _heroServices.DeleteHero(id);
            return Ok(heroes);
        }
    }
}

