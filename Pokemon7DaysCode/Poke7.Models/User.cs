using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon7DaysCode.Poke7.Models
{
    internal class User
    {
        public string Name { get; set; }
        public List<Poke7> poke7List { get; set; } = new List<Poke7>();

        public User(string name)
        {
            Name = name;
        }
    }
}
