using ChallengeLibrary.Enums;
using ChallengeLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLibrary.Models
{
    public class GasCar : Vehicle, IVehicle
    {
        public string EngineSize { get; set; }

        public Color Color { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Model Model { get; set; }
        public int YearBuilt { get; set; }

        public int Calculate()
        {
            return MathLogic.VehicleAgeCalculate(YearBuilt);
        }
    }
}
