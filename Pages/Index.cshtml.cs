using EnvisionStudioPokemonAPI.Models;
using EnvisionStudioPokemonAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnvisionStudioPokemonAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PokemonService _pokemonService;
        public List<PokemonResult> PokemonResults { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PokemonService pokemonService)
        {
            _logger = logger;
            _pokemonService = pokemonService;
        }

        public async Task OnGetAsync()
        {
            var response = await _pokemonService.FetchPokemonData("https://pokeapi.co/api/v2/pokemon/");
            PokemonResults = response.results;
        }
    }
} 