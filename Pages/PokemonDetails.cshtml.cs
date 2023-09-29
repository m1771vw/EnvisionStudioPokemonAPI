using EnvisionStudioPokemonAPI.Services;
using EnvisionStudioPokemonAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
                // Retrieve Pokemon details based on the PokemonId stored in the hidden input
                var pokemonDetail = await _pokemonService.FetchPokemonDetail($"https://pokeapi.co/api/v2/pokemon/{pokemonName}/");
                var favoritePokemon = new FavoritePokemon
                {
                    UserId = "1",
                    Name = pokemonDetail.Name,
                    Height = pokemonDetail.Height,
                    Order = pokemonDetail.Order, // Assuming you have this property in PokemonDetail
                    Weight = pokemonDetail.Weight,
                    Type1 = pokemonDetail.Types.FirstOrDefault()?.Type.Name, // Get the first type name
                    Type2 = pokemonDetail.Types.Skip(1).FirstOrDefault()?.Type.Name // Get the second type name if available
                };

                // Call your service to add the Pokemon to favorites
                await _favoritePokemonService.AddPokemonToFavoritesAsync(favoritePokemon);

                // Redirect back to the Pokemon details page or another appropriate page
                return RedirectToPage("PokemonDetails", new { pokemonName = pokemonDetail.Name });
            }
            catch (Exception ex)
            {
                // Handle the error and display a message to the user
                TempData["ErrorMessage"] = $"Failed to add Pokemon to favorites: {ex.Message}";
                return Page();
            }
        }
    }
}
