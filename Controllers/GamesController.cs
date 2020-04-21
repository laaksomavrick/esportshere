using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Esportshere.Models;
using Esportshere.Data;
using Microsoft.Extensions.Logging;
using System.Linq;
using Esportshere.Dto;


namespace Esportshere.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly EsportshereContext _context;
        private readonly ILogger<GamesController> _logger;

        public GamesController(EsportshereContext context, ILogger<GamesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetGamesDto>>> GetGames()
        {
            return await _context.Games
            .Select(g => new GetGamesDto
            {
                Id = g.Id,
                Name = g.Name,
                ShortName = g.ShortName
            })
            .ToListAsync();
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGame(long id)
        {
            var game = await _context.Games.FindAsync(id);

            if (game == null)
            {
                return NotFound();
            }

            return game;
        }

    }
}
