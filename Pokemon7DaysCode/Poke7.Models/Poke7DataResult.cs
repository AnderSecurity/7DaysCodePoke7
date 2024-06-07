using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pokemon7DaysCode.Poke7.Models
{
    internal class Poke7DataResult
    {
        [JsonPropertyName("results")]
        public List<Poke7Data>? Results { get; set; }
    }
}
