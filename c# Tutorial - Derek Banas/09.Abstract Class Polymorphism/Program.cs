using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Abstract_Class_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach(Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCirc = s as Circle;
                Console.WriteLine(testCirc);
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");

                }
                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }

 
            }

            object circ1 = new Circle(40);
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("{0} Area : {1:f2}", circ2.Name, circ2.Area());

        }
    }

    //An abstract class may be used when you don't want to instantiate the class

    abstract class Shape
    {
        public string Name { get; set; }

        //non abstract function
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        //Abstract methods, which we want to be overriden by sub-classes
        //Was created only to be overriden
        public abstract double Area();
    }

    //Shape Sub-classes

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        public override void GetInfo()
        {
            base.GetInfo(); //Get the method from the base class
            Console.WriteLine($"It has a Radius of {Radius}");

        }
    }

    class Rectangle : Shape
    {
        public double Length { set; get; }
        public double Width { set; get; }

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a length of {Length} and a Width of {Width}");
        }
    }
}
