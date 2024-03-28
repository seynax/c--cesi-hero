using Cesi__Hero.Model;
using Cesi__Hero.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cesi__Hero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly IHeroServices _heroService;

        public IHeroServices HeroService => _heroService;

        public HeroesController(IHeroServices heroService)
        {
            _heroService = heroService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hero>>> GetAllHeroes()
        {
            var heroes = await _heroService.GetAllHero();
            if (heroes.Count == 0)
            {
                return NotFound("Aucun héros trouvé");
            }
            return Ok(heroes);
        }

        [HttpGet("{id}")]
        public ActionResult<Hero> GetHero(int id)
        {
            var hero = _heroService.GetHero(id);
            if (hero == null)
                return NotFound("Héros non trouvé");

            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Hero>>> AddHero([FromBody] Hero hero)
        {
            var heroes = await _heroService.AddHero(hero);
            return Ok(heroes);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<IEnumerable<Hero>>> UpdateHero(int id, [FromBody] Hero hero)
        {
            List<Hero> updatedHeroes = await _heroService.UpdateHero(id, hero);
            return Ok(updatedHeroes);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Hero>>> DeleteHero(int id)
        {
            var heroes = await _heroService.DeleteHero(id);
            return Ok(heroes);
        }
    }
}
