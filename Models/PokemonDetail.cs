namespace EnvisionStudioPokemonAPI.Models
{
    public class PokemonDetail
    {
        public List<AbilityInfo> Abilities { get; set; }
        public int BaseExperience { get; set; }
        public List<Form> Forms { get; set; }
        //public List<GameIndex> GameIndices { get; set; }
        // Add other properties as needed to represent the full JSON structure
    }
    public class Ability
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class AbilityInfo
    {
        public Ability Ability { get; set; }
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
    }

    public class Form
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    //public class GameIndex
    //{
    //    public int GameIndex { get; set; }
    //    public Version Version { get; set; }
    //}

    //public class Version
    //{
    //    public string Name { get; set; }
    //    public string Url { get; set; }
    //}
}
