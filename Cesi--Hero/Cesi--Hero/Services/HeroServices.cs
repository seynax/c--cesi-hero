using System;
using System.Collections.Generic;
using System.Linq;
using Cesi__Hero.Model;

namespace Cesi__Hero.Services
{
    public class HeroServices : IHeroServices
    {
        private static IList<Hero> _heroes = new List<Hero>
        {
            new Hero(1, "Jacky", "Thuning"),
            new Hero(2, "Null", "PasNull")
        };

        public List<Hero> AddHero(Hero hero)
        {
            _heroes.Add(hero);
            return new List<Hero>(_heroes);
        }

        public List<Hero> DeleteHero(int id)
        {
            var heroToRemove = _heroes.FirstOrDefault(hero => hero.Id == id);
            if (heroToRemove != null)
                _heroes.Remove(heroToRemove);

            return new List<Hero>(_heroes);
        }

        public List<Hero> GetAllHero()
        {
            return new List<Hero>(_heroes);
        }

        public Hero GetHero(int id)
        {
            return _heroes.FirstOrDefault(hero => hero.Id == id);
        }

        public List<Hero> UpdateHero(int id, Hero request)
        {
            var heroToUpdate = _heroes.FirstOrDefault(hero => hero.Id == id);
            if (heroToUpdate != null)
            {
                heroToUpdate.Name = request.Name;
                heroToUpdate.Superpower = request.Superpower;
            }

            return new List<Hero>(_heroes);
        }
    }
}


