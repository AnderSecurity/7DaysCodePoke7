
using System.Text.Json.Serialization;

namespace Pokemon7DaysCode.Poke7.Models
{
    internal class Ability
    {
        [JsonPropertyName("ability")]
        public AbilityDetails? abilityDetails { get; set; }
    }

    internal class AbilityDetails
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
