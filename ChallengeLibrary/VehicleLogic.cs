using ChallengeLibrary.Enums;
using System;
using System.Collections.Generic;

namespace ChallengeLibrary.Models
{
    public static class VehicleLogic
    {
        public static List<Vehicle> GenerateVehicleList()
        {
            Random random = new Random();
            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 0; i < 10; i++)
            {
                int randomVehicleNumber = random.Next(1, 3);
                // DRY for this.
                if (randomVehicleNumber == 1){
                    GasCar gasCar = new GasCar
                    {
                        Color = MathLogic.GetColor(),
                        Manufacturer = MathLogic.GetManufacturer(),
                        Model = MathLogic.GetModel(),
                        YearBuilt = MathLogic.GetYear()
                    };
                    vehicles.Add(gasCar);
                }
                else
                {
                    ElectricCar electricCar = new ElectricCar
                    {
                        Color = MathLogic.GetColor(),
                        Manufacturer = MathLogic.GetManufacturer(),
                        Model = MathLogic.GetModel(),
                        YearBuilt = MathLogic.GetYear()
                    };
                    vehicles.Add(electricCar);
                }
            }

            return vehicles;
        }

    }
}
