using EnvisionStudioPokemonAPI.Services;
using EnvisionStudioPokemonAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace EnvisionStudioPokemonAPI.Pages
{
    public class PokemonDetailsModel : PageModel
    {
        private readonly PokemonService _pokemonService;
        private readonly FavoritePokemonService _favoritePokemonService;

        public string PokemonName { get; set; }
        public PokemonDetail PokemonDetail { get; set; }
        public PokemonDetailsModel(PokemonService pokemonService, FavoritePokemonService favoritePokemonService)
        {
            _pokemonService = pokemonService;
            _favoritePokemonService = favoritePokemonService;

        }
        public async Task OnGetAsync(string pokemonName)
        {
            PokemonName = pokemonName;
            PokemonDetail = await _pokemonService.FetchPokemonDetail($"https://pokeapi.co/api/v2/pokemon/{pokemonName}/");
        }
        public async Task<IActionResult> OnPostAddToFavoriteAsync(string pokemonName)
        {
            try
            {
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
                var userId = "";
                if (userIdClaim != null)
                {
                    userId = userIdClaim.Value;
                }
                var pokemonDetail = await _pokemonService.FetchPokemonDetail($"https://pokeapi.co/api/v2/pokemon/{pokemonName}/");
                var favoritePokemon = new FavoritePokemon
                {
                    UserId = userId,
                    Name = pokemonDetail.Name,
                    Height = pokemonDetail.Height,
                    Order = pokemonDetail.Order, 
                    Weight = pokemonDetail.Weight,
                    Type1 = pokemonDetail.Types.FirstOrDefault()?.Type.Name, 
                    Type2 = pokemonDetail.Types.Count > 1 ? pokemonDetail.Types.Skip(1).First().Type.Name : null,
                    Front_Sprite = pokemonDetail.Sprites.Front_Default,
                    Back_Sprite = pokemonDetail.Sprites.Back_Default
                };

                await _favoritePokemonService.AddPokemonToFavoritesAsync(favoritePokemon);

                return RedirectToPage("/FavoritePokemon");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to add Pokemon to favorites: {ex.Message}";
                return Page();
            }
        }

        public async Task<IActionResult> OnPostRemoveFromFavoriteAsync(string pokemonName)
        {
            try
            {
                await _favoritePokemonService.RemovePokemonFromFavoritesAsync(pokemonName);

                return RedirectToPage("/FavoritePokemon");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to remove Pokemon from favorites: {ex.Message}";
                return RedirectToPage("/FavoritePokemon");
            }
        }
    }
}
