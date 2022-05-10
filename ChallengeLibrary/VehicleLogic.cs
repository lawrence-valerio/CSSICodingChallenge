using ChallengeLibrary.Enums;
using System;
using System.Collections.Generic;

namespace ChallengeLibrary.Models
{
    public static class VehicleLogic
    {
        private static Random random = new Random();
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
                        Color = GetColor(),
                        Manufacturer = GetManufacturer(),
                        Model = GetModel(),
                        YearBuilt = GetYear()
                    };
                    vehicles.Add(gasCar);
                }
                else
                {
                    ElectricCar electricCar = new ElectricCar
                    {
                        Color = GetColor(),
                        Manufacturer = GetManufacturer(),
                        Model = GetModel(),
                        YearBuilt = GetYear()
                    };
                    vehicles.Add(electricCar);
                }
            }

            return vehicles;
        }

        public static int GetYear()
        {
            int output = random.Next(1949, DateTime.Now.Year);
            return output;
        }

        public static MotorType GetMotorType()
        {
            int motorCount = Enum.GetNames(typeof(MotorType)).Length;
            int output = random.Next(0, motorCount);

            return (MotorType)output;
        }

        public static EngineSize GetEngineSize()
        {
            int engineCount = Enum.GetNames(typeof(EngineSize)).Length;
            int output = random.Next(0, engineCount);

            return (EngineSize)output;
        }

        public static Color GetColor()
        {
            int colorCount = Enum.GetNames(typeof(Color)).Length;
            int output = random.Next(0, colorCount);

            return (Color)output;
        }

        public static Manufacturer GetManufacturer()
        {
            int manufacturerCount = Enum.GetNames(typeof(Manufacturer)).Length;
            int output = random.Next(0, manufacturerCount);

            return (Manufacturer)output;
        }

        public static Model GetModel()
        {
            int modelCount = Enum.GetNames(typeof(Model)).Length;
            int output = random.Next(0, modelCount);

            return (Model)output;
        }
    }
}
