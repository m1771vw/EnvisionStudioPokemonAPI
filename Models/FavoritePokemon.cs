using System.ComponentModel.DataAnnotations;

namespace EnvisionStudioPokemonAPI.Models
{
    public class FavoritePokemon
    {
        public int Id { get; set; }
        // Add other properties specific to FavoritePokemon
        [Required]
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
    }
}
