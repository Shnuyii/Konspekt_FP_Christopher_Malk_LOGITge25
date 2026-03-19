using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimene_projekt.Vehicles
{
    internal class Car : Vehicle
    {
        public int BootVolume { get; set; }
        public int SeatCount { get; set; }
        public Car(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {

        }
    }
}
