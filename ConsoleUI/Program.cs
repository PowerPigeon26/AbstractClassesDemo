using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */ // COMPLETED

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */ //COMPLETED

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            

            Car car1 = new Car()
            {
                Year = "1998",
                Make = "Chrysler",
                Model = "Concorde",
                HasTrunk = true,
                NumOfSeats = 5
            };
            Vehicle car2 = new Car()
            {
                Year = "2005",
                Make = "Acura",
                Model = "Lemon",
                HasTrunk = true,
                NumOfSeats = 24  // hold up...
            };
            Motorcycle motorcycle1 = new Motorcycle()
            {
                Year = "3015",
                Make = "Tron",
                Model = "Movie",
                HasSideCart = false,
                HasWindShield = false
            };
            Vehicle motorcycle2 = new Motorcycle()
            {
                Year = "2015",
                Make = "Fast",
                Model = "Police",
                HasSideCart = true,
                HasWindShield = true
            };

            List<Vehicle> Vehicles = new List<Vehicle>() { car1, car2, motorcycle1, motorcycle2 };

            
            foreach(Vehicle vehicle in Vehicles)
            {
                vehicle.PrintCompleteVehicleInfo();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
            }

        }
    }
}
