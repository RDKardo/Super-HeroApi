using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Super_HeroApi.Services.SuperHeroService;

namespace Super_HeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService= superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var result = await _superHeroService.GetAllHeroes();
            if(result is null)
                return NotFound("Hero not found");
            return Ok(result);
        }
    }
}
