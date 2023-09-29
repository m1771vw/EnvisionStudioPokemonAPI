using EnvisionStudioPokemonAPI.Services;
using EnvisionStudioPokemonAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnvisionStudioPokemonAPI.Pages
{
    public class PokemonDetailsModel : PageModel
    {
        private readonly PokemonService _pokemonService;
        public string PokemonName { get; set; }
        public PokemonDetail PokemonDetail { get; set; }
        public PokemonDetailsModel(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }
        public async Task OnGetAsync(string pokemonName)
        {
            PokemonName = pokemonName;
            PokemonDetail = await _pokemonService.FetchPokemonDetail($"https://pokeapi.co/api/v2/pokemon/{pokemonName}/");
        }
    }
}
