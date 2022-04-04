using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public int BedSize { get; set; }
        public string ModelName { get; set; }

        public int NumberofWheels { get ; set ; }
        public bool HasSteeringWheel { get ; set ; }
        public int NumberofWindows { get ; set ; }
        public string Color { get ; set ; }

        public string CompanyName { get ; set ; }
        public string FactoryLocation { get ; set ; }
    }
}
