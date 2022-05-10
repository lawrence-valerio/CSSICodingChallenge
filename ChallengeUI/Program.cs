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

        public class GasCar : Vehicle, IVehicle
        {
            public string EngineSize { get; set; }

            public string Color { get; set; }
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public int YearBuilt { get; set; }

            public int Calculate()
            {
                throw new NotImplementedException();
            }
        }

        public class ElectricCar : Vehicle, IVehicle
        {
            public string MotorType { get; set; }

            public string Color { get; set; }
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public int YearBuilt { get; set; }

            public int Calculate()
            {
                throw new NotImplementedException();
            }
        }
    }
}
