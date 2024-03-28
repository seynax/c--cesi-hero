using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cesi__Hero.Model;

namespace Cesi__Hero.Services
{
    public class HeroServices : IHeroServices
    {
        private static IList<Hero> _heroes = new List<Hero>();

        public Task<List<Hero>> AddHero(Hero hero)
        {
            _heroes.Add(hero);
            return Task.FromResult(_heroes.ToList());
        }

        public Task<List<Hero>> DeleteHero(int id)
        {
            var heroToRemove = _heroes.FirstOrDefault(hero => hero.Id == id);
            if (heroToRemove != null)
                _heroes.Remove(heroToRemove);

            return Task.FromResult(_heroes.ToList());
        }

        public Task<List<Hero>> GetAllHero()
        {
            return Task.FromResult(_heroes.ToList());
        }

        public Hero GetHero(int id)
        {
            return _heroes.FirstOrDefault(hero => hero.Id == id);
        }

        public Task<List<Hero>> UpdateHero(int id, Hero request)
        {
            var heroToUpdate = _heroes.FirstOrDefault(hero => hero.Id == id);
            if (heroToUpdate != null)
            {
                heroToUpdate.Name = request.Name;
                heroToUpdate.School = request.School;
                heroToUpdate.Powers.Clear();
                foreach (var power in request.Powers)
                {
                    heroToUpdate.Powers.Add(power);
                }
            }

            return Task.FromResult(_heroes.ToList());
        }
    }
}

