using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberofWheels { get; set; }
        public bool HasSteeringWheel { get; set; }
        public int NumberofWindows { get; set; }
        public string Color { get; set; }

    }
}
