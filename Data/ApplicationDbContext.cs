using EnvisionStudioPokemonAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnvisionStudioPokemonAPI.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define your DbSet properties for each entity/table you want to work with
        //public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<FavoritePokemon> FavoritePokemons { get; set; }

    }
}
