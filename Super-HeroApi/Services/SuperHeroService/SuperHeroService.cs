using Microsoft.EntityFrameworkCore;

namespace Super_HeroApi.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly DataContext _context;
        public SuperHeroService(DataContext context)
        {
            _context= context;
        }
        public async Task<List<SuperHero>> GetAllHeroes()
        {
            try
            {
                var heroes = await _context.SuperHeroes.ToListAsync();
                return heroes;
            }
            catch (Exception ex )
            {
                return new List<SuperHero>();
            }
     
        }
    }
}
