using System.Text;
using System.Text.Json.Serialization;

namespace Pokemon7DaysCode.Poke7.Models
{
    internal class Poke7
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("height")]
        public int Height {  get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        [JsonPropertyName("abilities")]
        public List<Ability>? Abilities { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {this.Name}");
            sb.AppendLine($"Altura: {this.Height}");
            sb.AppendLine($"Peso: {this.Weight}");
            sb.AppendLine("\nHabilidades:");

            if (this.Abilities != null)
            {
                foreach (Ability ability in this.Abilities)
                {
                    sb.AppendLine(ability.abilityDetails?.Name);
                }
            }

            return sb.ToString();
        }
    }
}
