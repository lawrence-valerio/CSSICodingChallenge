using ChallengeLibrary.Enums;
using System;

namespace ChallengeLibrary.Models
{
    public static class MathLogic
    {
        private static Random random = new Random();
        public static int VehicleAgeCalculate(int yearBuilt)
        {
            int output = DateTime.Now.Year - yearBuilt;
            return output;
        }

        public static int GetYear()
        {

            int output = random.Next(1949, DateTime.Now.Year);
            return output;
        }

        public static Color GetColor()
        {
            int colorCount = Enum.GetNames(typeof(Color)).Length;
            int output = random.Next(0,colorCount);

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
