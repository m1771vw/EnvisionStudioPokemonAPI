using EnvisionStudioPokemonAPI.Models;
using EnvisionStudioPokemonAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace EnvisionStudioPokemonAPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PokemonService _pokemonService;
        
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public List<PokemonResult> PokemonResults { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PokemonService pokemonService)
        {
            _logger = logger;
            _pokemonService = pokemonService;
        }

        public int TotalPages { get; set; }
        public int CurrentPage { get; set; } = 1; 

        public async Task OnGetAsync(int? page)
        {
            var response = await _pokemonService.FetchPokemonData("https://pokeapi.co/api/v2/pokemon/");
            PokemonResults = response.results;
            if (int.TryParse(Request.Query["page"], out int pageNumber))
            {
                TotalPages = (int)Math.Ceiling(response.count / (double)PageSize);

                if (pageNumber >= 1 && pageNumber <= TotalPages)
                {
                    CurrentPage = pageNumber;
                }

                var offset = (CurrentPage - 1) * PageSize;

                var apiUrl = $"https://pokeapi.co/api/v2/pokemon?offset={offset}&limit={PageSize}";
                var newResponse = await _pokemonService.FetchPokemonData(apiUrl);
                PokemonResults = newResponse.results;
            }
            else
            {
                response = await _pokemonService.FetchPokemonData("https://pokeapi.co/api/v2/pokemon/");
                PokemonResults = response.results;
                TotalPages = (int)Math.Ceiling(response.count / (double)PageSize);

                if (pageNumber >= 1 && pageNumber <= TotalPages)
                {
                    CurrentPage = pageNumber;
                }

                var offset = (CurrentPage - 1) * PageSize;
            }
           
        }

    }
} 