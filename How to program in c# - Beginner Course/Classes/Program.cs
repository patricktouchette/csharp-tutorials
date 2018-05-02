using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Animal
    {
        //CLASS VARIABLES
        public static int Count = 0; //Static declares a variable that is common to all instances of this class

        public string name;
        public int age;
        public float happiness;

        //CLASS CONSTRUCTORS
        public Animal()
        {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;

            Count++;
        }

        public Animal(string _name, int _age, float _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            Count++;
        }

        //CLASS METHODS
        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();

            Animal cat = new Animal("Bobby", 10, 0.8f);
            cat.Print();


            Console.WriteLine("The number of animals is " + Animal.Count);
        }
    }
}
