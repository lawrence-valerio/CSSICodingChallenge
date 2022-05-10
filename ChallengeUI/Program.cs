using ChallengeLibrary.Interfaces;
using ChallengeLibrary.Models;
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
            List<Vehicle> vehicles = VehicleLogic.GenerateVehicleList();

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is IVehicle iVehicle)
                {
                    Console.WriteLine($"Manufacturer: {iVehicle.Manufacturer}, Model: {iVehicle.Model}, Color: {iVehicle.Color}, Year Built: {iVehicle.YearBuilt}, Age: {iVehicle.Calculate()}");
                }
            }

            Console.ReadLine();
        }
    }
}
