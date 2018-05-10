using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inheritance_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "barrrk"
            };



            whiskers.MakeSound();
            grover.MakeSound();

            grover.Sound = "Wooooooof";
            whiskers.SetAnimalIDInfo(1234, "Bob");
            grover.SetAnimalIDInfo(4343, "paul");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 146));
            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Monkey",
                Sound = "EEEEeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wuff",
                Sound2 = "Geeeerrr"
            };

            monkey.MakeSound();
            spot.MakeSound();

        }
    }

    //sealed class Animal - sealed will prevent a subclass from inheriting from our class
    class Animal
    {
        private string name;
        protected string sound; //field data can be changed by a subclass directly

        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} had the ID of {animalIDInfo.IDNum} and is owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound() //polymorphism by adding virtual. Allows subclass MakeSound() methods to overide this method.
        {
            Console.WriteLine($"{Name}, says {Sound}"); // $ sign allows for interpolation, you can write variables directly
        }

        public Animal() :this("No Name", "No Sound") { }

        public Animal(string name) : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        //inner class withing Animal Class - /helper class
        //The inner class is able to access private members of the outer class that surrounds it
        //Provide health info on animals
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }

    }

    class Dog : Animal  //inherit from animal class
    {
        public string Sound2 { get; set; } = "Grrrrr";

        public override void MakeSound() // overwrite method
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name", 
            string sound = "No Sound",
            string sound2 = "No Sound2")
            :base(name, sound)
        {
            Sound2 = sound2;
        }
    }

    //delegate / aggregate object which is stored within the animal class
    class AnimalIDInfo
    {
        public int IDNum { get; set; } = 0; //autogenerate getters and setters and set default value to 0
        public string Owner { get; set; } = "No Owner";

    }
}
