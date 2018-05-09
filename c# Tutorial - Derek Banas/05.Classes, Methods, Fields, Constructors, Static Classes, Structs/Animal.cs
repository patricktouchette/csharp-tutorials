using System;


namespace _5.Classes__Methods__Fields__Constructors__Static_Classes__Structs
{
    class Animal
    {
        public string name;
        public string sound;

        //overide constructor
        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
            numOfAnimals++;

        }

        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(string name = "No Name", string sound="No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

    }
}
