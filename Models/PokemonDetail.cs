using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnvisionStudioPokemonAPI.Models
{
    public class PokemonDetail
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public List<AbilityInfo> Abilities { get; set; }
        public List<MoveInfo> Moves { get; set; }
        public Sprites Sprites { get; set; }
        public List<StatInfo> Stats { get; set; }
        public List<TypeInfo> Types { get; set; }
    }

    public class AbilityInfo
    {
        [Key]
        public int Id { get; set; }
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
        public Ability Ability { get; set; }
    }

    public class MoveInfo
    {
        [Key]
        public int Id { get; set; }
        public Move Move { get; set; }
    }

    public class TypeInfo
    {
        [Key]
        public int Id { get; set; }
        public int Slot { get; set; }
        public Type Type { get; set; }
    }

    public class Sprites
    {
        [Key]
        public int Id { get; set; }
        public string FrontDefault { get; set; }
        public string FrontShiny { get; set; }
        public string FrontFemale { get; set; }
        public string FrontShinyFemale { get; set; }
        public string BackDefault { get; set; }
        public string BackShiny { get; set; }
        public string BackFemale { get; set; }
        public string BackShinyFemale { get; set; }
    }

    public class Ability
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Move
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Type
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Stat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class StatInfo
    {
        [Key]
        public int Id { get; set; }
        public Stat Stat { get; set; }
        public int Effort { get; set; }
        public int BaseStat { get; set; }
    }
}
