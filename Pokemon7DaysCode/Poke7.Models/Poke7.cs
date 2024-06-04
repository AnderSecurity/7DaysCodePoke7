using System.Text.Json.Serialization;

namespace Pokemon7DaysCode.Poke7.Models
{
    internal class Poke7
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        public string? Height {  get; set; }
        public string? Weight { get; set; }
        [JsonPropertyName("abilities")]
        public List<Ability>? Abilities { get; set; }
    }
}
