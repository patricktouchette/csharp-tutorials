using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //myCar.Make = "oldsmobile";
            //myCar.Model = "cutlas supreme";
            //myCar.Year = 1986;
            //myCar.Color = "Silver";

            Car myOtherCar;
            myOtherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            myOtherCar = null;
            myCar = null;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "white");
            Console.WriteLine("{0} {1} {2} {3}", myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);

            //Use the static car method
            Car.MyMethod();

        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car() //basic contructor funtion when you create a car object
        {
            this.Make = "Nissan";
            this.Model = "Model";
            this.Year = 2000;
            this.Color = "Black";

        }

        //Overloaded constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        //Static method , which you can use without creating an instance of the car class
        public static void MyMethod()
        {
            Console.WriteLine("Called the car MyMethod");
        }

    }

}
