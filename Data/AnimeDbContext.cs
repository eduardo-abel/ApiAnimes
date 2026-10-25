using ApiAnimes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAnimes.Data
{
    public class AnimeDbContext : DbContext
    {
        public AnimeDbContext(
            DbContextOptions<AnimeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Anime> Animes { get; set; }
    }
}