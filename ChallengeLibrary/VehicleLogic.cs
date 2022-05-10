using System;
using System.Collections.Generic;

namespace ChallengeLibrary.Models
{
    public static class VehicleLogic
    {
        public static List<Vehicle> GenerateList()
        {
            Random random = new Random();
            List<Vehicle> vehicles = new List<Vehicle>();

            for (int i = 0; i < 10; i++)
            {
                if(random.Next(1,2) == 1){
                    GasCar gasCar = new GasCar { Color = };
                    vehicles.Add(gasCar);
                }
            }

            return vehicles;
        }

    }
}
