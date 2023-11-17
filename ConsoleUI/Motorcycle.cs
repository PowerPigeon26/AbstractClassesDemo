using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public bool HasWindShield { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Abstraction of driving in Motorcyle class.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcyle class's own virtual driving method, nifty!");
        }

        public override void PrintCompleteVehicleInfo()
        {
            PrintVehicleInfo();
            Console.WriteLine($"Does it have a side cart: {HasSideCart}.");
            Console.WriteLine($"Does it have a wind Shield: {HasWindShield}.");
        }
    }
}
