using EnvisionStudioPokemonAPI.Data;
using EnvisionStudioPokemonAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnvisionStudioPokemonAPI.Services
{
    public class FavoritePokemonService
    {
        private readonly ApplicationDbContext _dbContext;

        public FavoritePokemonService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Add a Pokémon to favorites
        public async Task AddPokemonToFavoritesAsync(FavoritePokemon favoritePokemon)
        {
            // Check if the Pokémon is already in favorites for the user
            var existingFavorite = await _dbContext.FavoritePokemons
                .FirstOrDefaultAsync(fp => fp.UserId == favoritePokemon.UserId && fp.Name == favoritePokemon.Name);

            if (existingFavorite != null)
            {
                // Pokémon is already in favorites, you can handle this case as needed
                // For example, you might want to update properties or return a message.
                throw new InvalidOperationException("Pokemon is already in favorites.");
            }

            // Add the new favorite Pokémon
            _dbContext.FavoritePokemons.Add(favoritePokemon);
            await _dbContext.SaveChangesAsync();
        }

        // Remove a Pokémon from favorites
        public async Task RemovePokemonFromFavoritesAsync(int favoritePokemonId)
        {
            var favoritePokemon = await _dbContext.FavoritePokemons.FindAsync(favoritePokemonId);

            if (favoritePokemon != null)
            {
                _dbContext.FavoritePokemons.Remove(favoritePokemon);
                await _dbContext.SaveChangesAsync();
            }
        }

        // List favorite Pokémon for a user
        public async Task<List<FavoritePokemon>> ListFavoritePokemonsAsync(string userId)
        {
            return await _dbContext.FavoritePokemons
                .Where(fp => fp.UserId == userId)
                .ToListAsync();
        }
    }
}
