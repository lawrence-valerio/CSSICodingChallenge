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

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i] is GasCar gasCar)
                {
                    ConsoleHelpers.PrintGasCar(gasCar, i);
                }
                
                if(vehicles[i] is ElectricCar electricCar)
                {
                    ConsoleHelpers.PrintElectricCar(electricCar, i);
                }
            }

            Console.ReadLine();
        }
    }
}
