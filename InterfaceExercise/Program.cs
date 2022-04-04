using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany  --done

            //Create 3 classes called Car , Truck , & SUV  --done

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..  --done
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }            --done
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.   --done
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values      --done
            var tesla = new Car() { 
                CompanyName = "Tesla",
                FactoryLocation = "California",
                NumberofWheels = 4,
                HasSteeringWheel = true,
                NumberofWindows = 4,
                Color = "silver", 
                TrunkSize = 20,
                ModelName = "Model 3"            
            };
            var honda = new SUV() {
                CompanyName = "Honda",
                FactoryLocation = "Mexico",
                NumberofWheels = 4,
                HasSteeringWheel = true,
                NumberofWindows = 4,
                Color = "blue",
                CargoHoldSize = 25,
                ModelName = "HR-V"
            };
            var rivian = new Truck() {
                CompanyName = "Rivian",
                FactoryLocation = "Georgia",
                NumberofWheels = 4,
                HasSteeringWheel = true,
                NumberofWindows = 4,
                Color = "red",
                BedSize = 30,
                ModelName = "R1T"
            };

            Console.WriteLine($"This {tesla.Color} {tesla.CompanyName} {tesla.ModelName} was built in {tesla.FactoryLocation}.");
            Console.WriteLine($"Included features: {tesla.NumberofWheels} wheels, {tesla.NumberofWindows} windows, {tesla.TrunkSize} cubic feet of trunk storage, and a steering wheel.");
            Console.WriteLine("----------");
            Console.WriteLine($"Here we have a {honda.Color} {honda.CompanyName} {honda.ModelName} that was built in {honda.FactoryLocation}.");
            Console.WriteLine($"Included features: {honda.NumberofWheels} wheels, {honda.NumberofWindows} windows, {honda.CargoHoldSize} cubic feet of cargo space, and a steering wheel.");
            Console.WriteLine("----------");
            Console.WriteLine($"And here comes a {rivian.Color} {rivian.CompanyName} {rivian.ModelName} built in {rivian.FactoryLocation}.");
            Console.WriteLine($"Included features: {rivian.NumberofWheels} wheels, {rivian.NumberofWindows} windows, {rivian.BedSize} cubic feet of bed space, and a steering wheel.");
            Console.WriteLine("----------");

        }
    }
}
