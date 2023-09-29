using EnvisionStudioPokemonAPI.Models;
using System.Text.Json;

namespace EnvisionStudioPokemonAPI.Services
{
    public class PokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PokemonApiResponse> FetchPokemonData(string url)
        {
            var response = await _httpClient.GetAsync(url);
            var responseData = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<PokemonApiResponse>(responseData);
        }

        public async Task<PokemonDetail> FetchPokemonDetail(string url)
        {
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PokemonDetail>();
        }
    }
}
