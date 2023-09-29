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

        public async Task AddPokemonToFavoritesAsync(FavoritePokemon favoritePokemon)
        {
            var existingFavorite = await _dbContext.FavoritePokemons
                .FirstOrDefaultAsync(fp => fp.UserId == favoritePokemon.UserId && fp.Name == favoritePokemon.Name);

            if (existingFavorite != null)
            {
                throw new InvalidOperationException("Pokemon is already in favorites.");
            }

            _dbContext.FavoritePokemons.Add(favoritePokemon);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemovePokemonFromFavoritesAsync(string pokemonName)
        {
            var Name = pokemonName;
            var favoritePokemon = await _dbContext.FavoritePokemons.FirstOrDefaultAsync(fp => fp.Name == pokemonName);

            if (favoritePokemon != null)
            {
                _dbContext.FavoritePokemons.Remove(favoritePokemon);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<FavoritePokemon>> ListFavoritePokemonsAsync(string userId)
        {
            return await _dbContext.FavoritePokemons
                .Where(fp => fp.UserId == userId)
                .ToListAsync();
        }
    }
}
