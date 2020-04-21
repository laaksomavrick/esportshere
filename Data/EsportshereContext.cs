using Microsoft.EntityFrameworkCore;
using Esportshere.Models;

namespace Esportshere.Data
{
    public class EsportshereContext : DbContext
    {

        public DbSet<Game> Games { get; set; }

        public DbSet<Event> Events { get; set; }

        public EsportshereContext(DbContextOptions<EsportshereContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Create games by default
            modelBuilder.Entity<Game>().HasData(new Game[] {
                new Game { Id = 1, Name = "Counter Strike: Global Offensive", ShortName = "CS:GO"},
                new Game { Id = 2, Name = "League of Legends", ShortName = "LoL"},
             });

        }
    }
}