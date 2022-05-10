﻿using ChallengeLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLibrary.Models
{
    public class ElectricCar : Vehicle, IVehicle
    {
        public string MotorType { get; set; }

        public string Color { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearBuilt { get; set; }

        public int Calculate()
        {
            throw new NotImplementedException();
        }
    }
}