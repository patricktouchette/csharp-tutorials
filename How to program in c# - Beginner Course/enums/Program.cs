using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enums
{
    enum Breed { Bulldog, Boxer, Poodle, chichuahua};

    //Base Class
    class Animal
    {
        public string name;
        public int age;
        public float happiness;
    }

    //Derived Class
    class Dog : Animal // Inherit from the animal class
    {
        public Breed breed;

        public Dog(string _name, int _age, float _happiness, Breed _breed)
        {
            name = _name;
            age = _age;
            happiness = _happiness;
            breed = _breed;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
            Console.WriteLine("Breed: " + breed);
        }

        public void Bark()
        {
            Console.WriteLine("WUF!!");
            base.happiness += 0.1f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("bob", 4, 0.5f, Breed.Poodle);
            dog.Print();
        }
    }
}
