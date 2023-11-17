using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public int NumOfSeats { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Abstraction of driving in Car class.");
        }

        public override void PrintCompleteVehicleInfo()
        {
            PrintVehicleInfo();
            Console.WriteLine($"Does it have a trunk: {HasTrunk}.");
            Console.WriteLine($"It has {NumOfSeats} number of seats.");
        }
    }
}
