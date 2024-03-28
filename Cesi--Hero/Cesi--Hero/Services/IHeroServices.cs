using Cesi__Hero.Model;

namespace Cesi__Hero.Services
{
    public interface IHeroServices
    {
        Task<List<Hero>> GetAllHero();
        Hero GetHero(int id);
        Task<List<Hero>> AddHero(Hero hero);
        Task<List<Hero>> UpdateHero(int id, Hero request);
        Task<List<Hero>> DeleteHero(int id);
    }
}
