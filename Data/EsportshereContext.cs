using Microsoft.EntityFrameworkCore;
using Esportshere.Models;

namespace Esportshere.Data
{
    public class EsportshereContext : DbContext
    {

        public DbSet<Game> Games { get; set; }

        public EsportshereContext(DbContextOptions<EsportshereContext> options) : base(options)
        {
        }
    }
}