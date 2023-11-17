using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "1500";
        public string Make { get; set; } = "Wood";
        public string Model { get; set; } = "Pioneer";

        public abstract void DriveAbstract(); //stubbed out method
        
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Riding the virtual dirt roads.");
        }

        public void PrintVehicleInfo()
        {
            Console.WriteLine($"Year: {Year}\nMake: {Make}\nModel: {Model}");
        }

        public abstract void PrintCompleteVehicleInfo();

    }
}
