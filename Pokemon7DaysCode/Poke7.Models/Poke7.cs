using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

namespace Pokemon7DaysCode.Poke7.Models
{
    internal class Poke7
    {
        private int _hunger;
        private int _sleep;
        private int _mood;

        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("weight")]
        public int Weight { get; set; }
        [JsonPropertyName("abilities")]
        public List<Ability>? Abilities { get; set; }

        public int Hunger
        {
            get { return _hunger; }
            set { this._hunger = this.CheckRange(value, nameof(Hunger)); }
        }
        public int Sleep
        {
            get { return _sleep; }
            set { this._sleep = this.CheckRange(value, nameof(Sleep)); }
        }
        public int Mood
        {
            get { return _mood; }
            set { this._mood = this.CheckRange(value, nameof(Mood)); }
        }      

        public Poke7()
        {
            this._mood = 5;
            this._hunger = 5;
            this._sleep = 5;
        }

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

        private int CheckRange(int value, string propertyName)
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentOutOfRangeException(propertyName, $"{propertyName} deve estar entre 0 e 10!");
            }

            return value;
        }

        public void Play()
        {
            this.Mood++;
            this.Sleep--;
        }

        public void Eat()
        {
            this.Hunger++;
            this.Sleep--;
        }

        public void Nap()
        {
            this.Sleep++;
            this.Hunger--;
            this.Mood--;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Humor: {this.Mood}");
            Console.WriteLine($"Fome: {this.Hunger}");
            Console.WriteLine($"Sono: {this.Sleep}");            
        }
    }
}
