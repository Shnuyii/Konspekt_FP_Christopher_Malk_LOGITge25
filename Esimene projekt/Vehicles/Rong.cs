using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimene_projekt.Vehicles
{
    internal class Rong : Vehicle
    {
        public int Vagunid { get; set; }
        public int RongiPikkus { get; set; }
        public Rong(string model, CarMark mark, string plate, string colour, decimal unloadedWeight, List<string> equipment) : base(model, mark, plate, colour, unloadedWeight, equipment)
        {
        }

        public override string GetInfo()
        //klassi "Rong" meetod "GetInfo" asendab baasklassist tulevat meetodit kaitstud sõna "override" abil, kuna baasklassis oleval meetodil on juures kaitstud sõna "virtual"
        {
            return $"This is a {Mark} model, it is {Colour} color and has {Vagunid} passenger carriages. \nIt is {RongiPikkus} long.";
        }
    }
}
