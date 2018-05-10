using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OOP_Game___Solution
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Warrior
    {
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        //random numbers
        Random rnd = new Random();

        //constructor
        public Warrior(string name="Warrior", double health =0,
            double attkMax = 0, double blockMax =0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        //Attack Method
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        //Block Method
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax); //convert double to int
        }
    }

    //utility Class, therefore methods should be static
    class Battle
    {
        //StartFight
        //Warrior 1 and Warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }


        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            if (dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;

            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and deals {2} damage",
                warriorA.Name, warriorB.Name, dmg2WarB);
            Console.WriteLine("{0} has {1} Health\n",
                warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorius\n",
                    warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
