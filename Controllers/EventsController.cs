using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Esportshere.Models;
using Esportshere.Data;
using Microsoft.Extensions.Logging;

namespace Esportshere.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EsportshereContext _context;
        private readonly ILogger<GamesController> _logger;

        public EventsController(EsportshereContext context, ILogger<GamesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(long id)
        {
            var esportsEvent = await _context.Events.FindAsync(id);

            if (esportsEvent == null)
            {
                return NotFound();
            }

            return esportsEvent;
        }

    }
}
