using ChallengeLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLibrary.Interfaces
{
    public interface IVehicle
    {
        Color Color { get; set; }
        Manufacturer Manufacturer { get; set; }
        Model Model { get; set; }
        int YearBuilt { get; set; }

        int Calculate();
    }
}
