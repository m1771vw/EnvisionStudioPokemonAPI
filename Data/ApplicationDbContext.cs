using EnvisionStudioPokemonAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnvisionStudioPokemonAPI.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<FavoritePokemon> FavoritePokemons { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
