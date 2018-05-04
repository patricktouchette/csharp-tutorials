using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        //Base Class
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

            public void PrintBase()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);
            }
        }

        //Derived Class
        class Dog : Animal // Inherit from the animal class
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("WUF!!");
                base.happiness += 0.1f;
            }
        }

        class Cat : Animal // Inherit from the animal class
        {
            public int cuteness;

            public void Meow()
            {
                Console.WriteLine("Meooow!!");
            }
        }

        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine("New happiness: " + spotty.happiness);
        }
    }
}
