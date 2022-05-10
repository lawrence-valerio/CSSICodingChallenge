using ChallengeLibrary.Enums;
using System;

namespace ChallengeLibrary.Models
{
    public static class MathLogic
    {
        public static int AgeCalculate(int yearBuilt)
        {
            int output = DateTime.Now.Year - yearBuilt;
            return output;
        }

        public static int GetColor()
        {
            Random random = new Random();
            int colorCount = Enum.GetNames(typeof(Color)).Length;
            int output = random.Next(0,colorCount);

            return output;
        }

        public static int GetManufacturer()
        {
            Random random = new Random();
            int manufacturerCount = Enum.GetNames(typeof(Manufacturer)).Length;
            int output = random.Next(0, manufacturerCount);

            return output;
        }

        public static int GetModedl()
        {
            Random random = new Random();
            int modelCount = Enum.GetNames(typeof(Model)).Length;
            int output = random.Next(0, modelCount);

            return output;
        }
    }
}
