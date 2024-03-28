using Cesi__Hero.Model;

namespace Cesi__Hero.Services
{
    public interface IHeroServices
    {
        List<Hero> GetAllHero();
        Hero GetHero(int id);
        List<Hero> AddHero(Hero hero);
        List<Hero> UpdateHero(int id, Hero request);
        List<Hero> DeleteHero(int id);
    }
}
