using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimene_projekt.Vehicles
{
    internal class Laev : Vehicle
    {
        public int LaevaSuurus {  get; set; }
        public int LaevaKiirus { get; set; }
        public Laev(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
    }
}
