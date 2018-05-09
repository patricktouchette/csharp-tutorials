using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Classes__Methods__Fields__Constructors__Static_Classes__Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Structs
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1: {0} ", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length : {0}", rect2.length);

            //2. Classes - check out Animal.cs
            Animal fox = new Animal()
            {
                name = "RedFox",
                sound = "Raaww"
            };

            Console.WriteLine("New animal: {0}, # of Animals : {1}", fox.name, Animal.GetNumAnimals());
            fox.MakeSound();

            Animal turtle = new Animal();
            Console.WriteLine("New animal: {0}, # of Animals : {1}", turtle.name, Animal.GetNumAnimals());
            turtle.MakeSound();

            Animal chicken = new Animal("yellowTheChicken", "bawwwk baowwwk");
            Console.WriteLine("New animal: {0}, # of Animals : {1}", chicken.name, Animal.GetNumAnimals());
            chicken.MakeSound();

            //3. Static Class
            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("Rectangle", 5, 10));
            Console.WriteLine("Area of triangle : {0}", ShapeMath.GetArea("Triangle", 5, 10));
            Console.WriteLine("Area of circle : {0}", ShapeMath.GetArea("Circle", 5));
            Console.WriteLine("Area of nothing : {0}", ShapeMath.GetArea("nothing"));

            //4. Creating a Null variable
            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null ");
            }
            Console.WriteLine(!randNum.HasValue);
        }
    }

    //1. Structs - Structs are a user defined type that contains moddable fields and methods
    struct Rectangle
    {
        public double length;
        public double width;

        //Constructor method
        public Rectangle(double l = 1, double w = 1)
        {
            length = l;
            width = w;
        }

        public double Area()
        {
            return length * width;
        }
    }

    //Utility Class
    public static class ShapeMath
    {
        public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return (length1 * length2) / 2;
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(length1, 2);
            }
            else
            {
                return -1;
            }
        }
    }
 
}
