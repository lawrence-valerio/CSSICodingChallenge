using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public interface IVehicle
        {
            string Color { get; set; }
            string Manufacturer { get; set; }
            string Model { get; set; }
            int YearBuilt { get; set; }

            int Calculate();
        }

        public class Vehicle
        {
            public int NumberOfWheels { get; set; }
            public int NumberOfDoors { get; set; }
        }
    }
}
