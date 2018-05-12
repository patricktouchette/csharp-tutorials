using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generic_Collections__Methods__Structs__Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic collections are type safe and better performance
            List<int> numList = new List<int>();
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            animalList.Insert(1, new Animal() { Name = "Steve" });

            animalList.RemoveAt(2);

            Console.WriteLine("Num of Animal : {0}", animalList.Count());

            //its also possible to use these on Lists : Stack<T>, Queue<T>, Dictionary<TKey, TValue> 

            foreach (Animal a in animalList)
            {
                Console.WriteLine(a.Name);
            }

            //Generic Method
            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            string strX = "3", strY = "2";
            Animal.GetSum<string>(ref strX, ref strY);

            //Structs
            Rectangle<int> rec1 = new Rectangle<int>(20, 50);
            Console.WriteLine(rec1.GetArea());

            Rectangle<string> rec2 = new Rectangle<string>("2220", "51");
            Console.WriteLine(rec2.GetArea());

            //Delegates
            Arithmetic add, sub, addSub;

            add = new Arithmetic(Add);
            sub = new Arithmetic(Subtract);
            addSub = add + sub;
            //sub = addSub - add;
            Console.WriteLine($"Add 6 & 10");
            add(6, 10);
            Console.WriteLine("Add & substract 10 & 4");
            addSub(10, 4);

        }


        class Animal
        {
            public string Name { get; set; }

            public Animal(string name = "No Name")
            {
                Name = name;
            }

            //Generic Method - used when you need many overloaded methods that differ only by their parameters
            public static void GetSum<T>(ref T num1, ref T num2)
            {
                double dblX = Convert.ToDouble(num1);
                double dblY = Convert.ToDouble(num2);
                Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
            }

        }

        //structs
        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string GetArea()
            {
                double dblWidth = Convert.ToDouble(Width);
                double dblLength = Convert.ToDouble(Length);
                return string.Format($"{Width} * {Length} = {dblWidth * dblLength}");
            }
        }

        //Delegate functions
        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

    }
}
