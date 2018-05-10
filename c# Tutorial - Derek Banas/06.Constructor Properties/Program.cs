using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Constructor_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Whiskers");  //setter
            cat.Sound = "Meow";   //property

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            cat.Owner = "Derek";

            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);

            Animal fox = new Animal("Oscar", "raawrr");
            Console.WriteLine("{0} shelter id is {1}", fox.GetName(), fox.idNum);

            Console.WriteLine("# of Animals : {0}", Animal.NumOfAnimals);
        }
    }

    class Animal
    {
        private string name;
        private string sound;

        public const string SHELTER = "Home for Animals";

        public readonly int idNum;

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        //Constructor to set defaults
        public Animal()
        :this("No Name", "No Sound") { }

        public Animal(string name) : this(name, "No Sound") { }

        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random rnd = new Random();
            idNum = rnd.Next(1, 2000);
        }

        //setter
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name ca't contain numbers");
            }
        }

        //getter - getter/accessor is used to provide output aside from the value that is stored
        public string GetName()
        {
            return name;
        }

        //Define getters and setters through properties
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }
                sound = value;
            }
        }

        public string Owner { get; set; } = "No Owner";

        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }

    }
}