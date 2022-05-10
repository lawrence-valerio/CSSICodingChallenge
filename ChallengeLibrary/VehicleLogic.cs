using ChallengeLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

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

                if (randomVehicleNumber == 1){
                    GasCar gasCar = new GasCar
                    {
                        Color = GetColor(),
                        Manufacturer = GetManufacturer(),
                        Model = GetModel(),
                        YearBuilt = GetYear(),
                        EngineSize = GetEngineSize(),
                        NumberOfDoors = 4,
                        NumberOfWheels = 4
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
                        YearBuilt = GetYear(),
                        MotorType = GetMotorType(),
                        NumberOfDoors = 4,
                        NumberOfWheels = 4
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

        public static List<Vehicle> SortedVehicleList()
        {
            List<Vehicle> unsortedList = GenerateVehicleList();
            List<Vehicle> gasCarList = new List<Vehicle>();
            List<Vehicle> electricCarList = new List<Vehicle>();

            for (int i = 0; i < unsortedList.Count; i++)
            {
                if (unsortedList[i] is GasCar gasCar)
                {
                    gasCarList.Add(gasCar);
                }

                if (unsortedList[i] is ElectricCar electricCar)
                {
                    electricCarList.Add(electricCar);
                }
            }

            List<Vehicle> sortedList = gasCarList.Concat(electricCarList).ToList();
            return sortedList;
        }
    }
}
