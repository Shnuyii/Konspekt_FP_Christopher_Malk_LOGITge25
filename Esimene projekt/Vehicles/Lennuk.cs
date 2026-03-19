using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimene_projekt.Vehicles
{
        public enum TravelClass
        {
            FirstClass, SecondClass, TouristClass, BaggageRoom
        }
    internal class Lennuk : Vehicle
    {
        public int TiivaLaius { get; set; }
        public int LennuKiirus { get; set; }
        public Lennuk(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }
    }
}
