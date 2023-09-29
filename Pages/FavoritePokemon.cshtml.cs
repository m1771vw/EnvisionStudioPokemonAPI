using EnvisionStudioPokemonAPI.Models;
using EnvisionStudioPokemonAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace EnvisionStudioPokemonAPI.Pages
{
    public class FavoritePokemonModel : PageModel
    {
        private readonly FavoritePokemonService _favoritePokemonService;
        public List<FavoritePokemon> FavoritePokemons { get; set; }

        public FavoritePokemonModel(FavoritePokemonService favoritePokemonService)
        {
            _favoritePokemonService = favoritePokemonService;
        }
        public async void OnGetAsync()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            var userId = "";
            if (userIdClaim != null)
            {
                userId = userIdClaim.Value;
            }
            FavoritePokemons = await _favoritePokemonService.ListFavoritePokemonsAsync(userId);
        }
    }
}
