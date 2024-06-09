using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon7DaysCode.Poke7.Models
{
    internal class User
    {
        private Poke7? _selectedPoke7;
        public string? Name { get; set; }
        public List<Poke7>? Poke7List { get; set; } = new List<Poke7>();
        public Poke7? SelectedPoke7
        {
            get { return this._selectedPoke7; }
            set
            {
                if (value != null && this.Poke7List != null && this.Poke7List!.Exists(p => p.Equals(value)))
                {
                    this._selectedPoke7 = value;
                }
                else
                {
                    throw new Exception("O poke7 não existe na sua lista!");
                }
            }
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
