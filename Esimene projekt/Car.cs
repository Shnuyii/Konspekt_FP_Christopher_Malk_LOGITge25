using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimene_projekt
{
    public enum CarMark
    {
        Toyota, Ford, Trashla, Subaru, Saab, Volvo, BMW, Mini, Škoda,
    }
    public class Car
    {
        public Car(
            string model,
            CarMark mark,
            string plate,
            string colour,
            decimal unloadedWeight, //one unit is one ton
            List<string>equipment)
        {
            Model = model;
            Mark = mark;
            LicensePlate = plate;
            Colour = colour;
            EmptyWeight = unloadedWeight;
            Equipment = equipment;
        }

        public string Model { get; set; }
        public CarMark Mark { get; set; }
        public string LicensePlate { get; set; }
        public string Colour { get; set; }
        public decimal EmptyWeight { get; set; } = 0;
        public List<string>? Equipment { get; set; }
        /// <summary>
        /// Returns info about this car
        /// </summary>
        /// <returns>Human readable sentence as a string</returns>
        public string GetInfo()
        {
            return $"This is a {Mark} model, it is {Colour} color and weighs {EmptyWeight} tons. \nLicense plate number is {LicensePlate}";
        }
        public void SeeEquipment()
        {
            Console.WriteLine("This car has:");
            foreach (var thing in Equipment)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
