using ChallengeLibrary.Enums;
using System;

namespace ChallengeLibrary.Models
{
    public static class MathLogic
    {
        public static int VehicleAgeCalculate(int yearBuilt)
        {
            int output = DateTime.Now.Year - yearBuilt;
            return output;
        }
    }
}
