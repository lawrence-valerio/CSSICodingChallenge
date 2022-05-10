using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLibrary.Interfaces
{
    public interface IVehicle
    {
        string Color { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        int YearBuilt { get; set; }

        int Calculate();
    }
}
