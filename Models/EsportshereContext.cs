using Microsoft.EntityFrameworkCore;

namespace Esportshere.Models
{
    public class EsportshereContext : DbContext
    {
        public EsportshereContext(DbContextOptions<EsportshereContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}