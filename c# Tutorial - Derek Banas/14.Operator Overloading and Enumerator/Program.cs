using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Operator_Overloading_and_Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm myAnimals = new AnimalFarm();
            myAnimals[0] = new Animal("Wilbur");
            myAnimals[1] = new Animal("Templeton");
            myAnimals[2] = new Animal("Gander");
            myAnimals[3] = new Animal("Charlotte");

            foreach (Animal i in myAnimals)
            {
                Console.WriteLine(i.Name);
            }

            Box myBox = new Box();
            Console.WriteLine(myBox);
            Console.WriteLine( myBox.ToString());

            Box Box1 = new Box(2, 3, 4);
            Box Box2 = new Box(5, 6, 7);

            Box Box3 = Box1 + Box2;

            Console.WriteLine(Box1.ToString());
            Console.WriteLine(Box2.ToString());
            Console.WriteLine(Box3.ToString());

            Console.WriteLine($"Box3 int: {(int)Box3}");

            Box Box4 = (Box)4;
            Console.WriteLine("Box 4: From int" + Box4.ToString());
            Console.WriteLine("4 cast as Box: " + (Box)4);

            var shopkins = new { Name = "Shopkins", Price = 4.99 };

            Console.WriteLine("{0} cost ${1}", shopkins.Name, shopkins.Price);

            var toyArray = new[] {
                new {Name = "Yo-Kai Pack", Price = 4.99},
                new {Name = "Legos", Price = 9.99}
            };

            foreach(var item in toyArray)
            {
                Console.WriteLine("{0} costs ${1}", item.Name, item.Price);
            }



        }
    }

    class Animal
    {
        public string Name { get; set; }

        public Animal(string name = "No Name")
        {
            Name = name;
        }
    }

    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }
        public AnimalFarm()
        {

        }

        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count
        {
            get { return animalList.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }

    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box()
            : this(1, 1, 1) { }

        public Box(double l, double w, double b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }

        //Overload the + operator
        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return newBox;

        }

        //Overload the - operator
        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return newBox;

        }

        //Overload the == operator
        public static bool operator ==(Box box1, Box box2)
        {
            {
                if ((box1.Length == box2.Length) &&
                    (box1.Width == box2.Width) &&
                    (box1.Breadth == box2.Breadth))
                {
                    return true;
                }
                return false;
            }

        }

        //Overload the != operator
        public static bool operator !=(Box box1, Box box2)
        {
            {
                if ((box1.Length != box2.Length) ||
                    (box1.Width != box2.Width) ||
                    (box1.Breadth != box2.Breadth))
                {
                    return true;
                }
                return false;
            }

        }

        //Override ToString
        public override string ToString()
        {
            return string.Format("Box with Height: {0}, Width {1} , Breadth {2}", Length, Width, Breadth);
        }

        //Convert from Box to Int
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }

    } //box
} //namespace