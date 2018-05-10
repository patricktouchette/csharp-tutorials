using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", buick.Brand);
            }
        }

        interface IDrivable
        {
            int Wheels { get; set; }
            double Speed { get; set; }
            void Move();
            void Stop();
        }

        class Vehicle : IDrivable
        {
            public string Brand { get; set; }
            public int Wheels { get; set; }
            public double Speed { get; set; }

            public Vehicle(string brand = "No Brand", int wheels = 0,
                double speed = 0)
            {
                Brand = brand;
                Wheels = wheels;
                Speed = speed;
            }

            public void Move()
            {
                Console.WriteLine($"The {Brand} moves forward at {Speed} MPH");
            }

            public void Stop()
            {
                Console.WriteLine($"The{Brand} Stops");
                Speed = 0;
            }

        }
    }
}
