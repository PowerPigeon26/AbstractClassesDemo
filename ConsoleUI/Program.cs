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
