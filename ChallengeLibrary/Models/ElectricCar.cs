using ChallengeLibrary.Enums;
using ChallengeLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLibrary.Models
{
    public class ElectricCar : Vehicle, IVehicle
    {
        public MotorType MotorType { get; set; }

        public Color Color { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Model Model { get; set; }
        public int YearBuilt { get; set; }

        public int Calculate()
        {
            int currentYear = DateTime.Now.Year;
            int output = currentYear - YearBuilt;
            return output;
        }

        public int YearCalculate()
        {
            return MathLogic.VehicleAgeCalculate(YearBuilt);
        }
    }
}
