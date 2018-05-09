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
    }
}
