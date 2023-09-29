namespace EnvisionStudioPokemonAPI.Models
{
    public class PokemonApiResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<PokemonResult> results{ get; set; }
    }
}
