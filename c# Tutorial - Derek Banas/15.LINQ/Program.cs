using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.LINQ
{
    class Program
    {
        //LINQ - Language Integrated Query
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
            QueryArrayList();
            QueryCollection();
            QueryAnimalData();
        }

        static void QueryStringArray()
        {
            Console.WriteLine("\nQueryStringArray");
            string[] dogs = {"K 9", "Brian Griffin", "Scooby Doo",
                            "Old Yeller", "Rin tin Tin", "Benji",
                            "Charlie B. Barking", "Lassie", "Snoopy"};

            //Get dogs with spaces in their name
            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach(var i in dogSpaces)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            
        }

        static Array QueryIntArray()
        {
            Console.WriteLine("\nQueryIntArray");
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach(var i in gt20)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Get Type: {gt20.GetType()}");

            //Convert to list and array
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            nums[0] = 40;

            foreach(var i in gt20)
            {
                Console.WriteLine(i);
            }

            return arrayGT20;
        }

        static void QueryArrayList()
        {
            Console.WriteLine("\nQueryArrayList");
            ArrayList famAnimals = new ArrayList()
            {
                new Animal{Name = "Heidi",
                Height = .8,
                Weight = 18},

                new Animal
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130
                },

                new Animal
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();
            var smAnimals = from animal in famAnimalEnum
                            where animal.Weight <= 90
                            orderby animal.Name
                            select animal;

            foreach(var animal in smAnimals)
            {
                Console.WriteLine(animal);
            }

        }

        static void QueryCollection()
        {
            Console.WriteLine("\nQueryCollection");
            var animalList = new List<Animal>()
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200}
            };

            var bigDogs = from dog in animalList
                          where (dog.Weight > 70) && (dog.Height > 25)
                          orderby dog.Name
                          select dog;

            foreach(var dog in bigDogs)
            {
                Console.WriteLine(dog);
            }

            var test = new Animal("Bob", 40, 200);
            Console.WriteLine(animalList[0].GetType());
            Console.WriteLine(test.GetType());
            
        }

        static void QueryAnimalData()
        {
            Console.WriteLine("\nQueryAnimalData");
            //create animal array
            Animal[] animals = new[] 
            {
                new Animal{Name = "German Shepherd",
                Height = 25,
                Weight = 77,
                AnimalID = 1},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 4.4,
                AnimalID = 2},
                new Animal{Name = "Saint Bernard",
                Height = 30,
                Weight = 200,
                AnimalID = 3},
                new Animal{Name = "Pug",
                Height = 12,
                Weight = 16,
                AnimalID = 1},
                new Animal{Name = "Beagle",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner{Name = "Doug Parks",
                OwnerID = 1},
                new Owner{Name = "Sally Smith",
                OwnerID = 2},
                new Owner{Name = "Paul Brooks",
                OwnerID = 3}
            };

            var nameHeight = from a in animals
                             select new
                             {
                                 a.Name,
                                 a.Height
                             };

            Array arrNameHeight = nameHeight.ToArray();

            foreach(var i in arrNameHeight)
            {
                Console.WriteLine(i.ToString());
            }

            //innerjoin
            Console.WriteLine("\nInner Join");
            var innerJoin = from animal in animals
                            join owner in owners
                            on animal.AnimalID equals owner.OwnerID
                            orderby owner.Name descending
                            select new { OwnerName = owner.Name, AnimalName = animal.Name };

            foreach (var i in innerJoin) Console.WriteLine(i.ToString());

            //Group Join
            Console.WriteLine("\nGroup Join");
            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join animal in animals
                            on owner.OwnerID equals animal.AnimalID
                            into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animals = from owner2 in ownerGroup
                                          orderby owner2.Name
                                          select owner2
                            };

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var animal in ownerGroup.Animals)
                {
                    Console.WriteLine("* {0}", animal.Name);
                }
            }

        }
    }

    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal(string name = "No Name", 
            double weight = 0, double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} lbs and is {2} inches tall", Name, Weight, Height);
        }
    }

    class Owner
    {
        public string Name { get; set; }
        public int OwnerID { get; set; }
    }
}
