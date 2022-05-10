using ChallengeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeUI
{
    public static class ConsoleHelpers
    {
        public static void PrintGasCar(GasCar gasCar, int number)
        {
            Console.WriteLine($"{number + 1}. Manufacturer: {gasCar.Manufacturer}, Model: {gasCar.Model}");
            Console.WriteLine($"     Type: Gas Vehicle");
            Console.WriteLine($"     Color: {gasCar.Color}");
            Console.WriteLine($"     Engine Size: {gasCar.EngineSize} Cylinders");
            Console.WriteLine($"     Year Built: {gasCar.YearBuilt}");
            Console.WriteLine($"     Age: {gasCar.Calculate()} years");
            Console.WriteLine();
        }

        public static void PrintElectricCar(ElectricCar electricCar, int number)
        {
            Console.WriteLine($"{number + 1}. Manufacturer: {electricCar.Manufacturer}, Model: {electricCar.Model}");
            Console.WriteLine($"     Type: Electric Vehicle");
            Console.WriteLine($"     Color: {electricCar.Color}");
            Console.WriteLine($"     Motor Type: {electricCar.MotorType}");
            Console.WriteLine($"     Year Built: {electricCar.YearBuilt}");
            Console.WriteLine($"     Age: {electricCar.Calculate()} years");
            Console.WriteLine();
        }
    }
}
