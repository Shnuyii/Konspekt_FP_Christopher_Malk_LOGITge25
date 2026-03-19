using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimene_projekt.Vehicles
{
    internal class Truck : Vehicle
    {
        public int LoadWeight { get; set; }
        public int EnginePower { get; set; }
        public Truck(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {

        }
    }
}
