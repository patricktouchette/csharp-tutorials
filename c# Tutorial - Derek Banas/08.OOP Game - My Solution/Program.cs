using System;

//Game where two gladiators fight to the death

//My Solution to the tutorial #8, OOP Game from Derek Banas C# series

//Sample Output:
//Bob Attacks Maximus and Deals 74 damage
//Maximus has 69 health

//Maximus Attacks Bob and Deals 6 Damage
//Maximus has 6 health

//Bob Attacks Maximus and deals 70 damage
//Maximus has -1 health

//Maximus has died and Bob is Victorius

namespace _08.OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Bob", 1000, 120, 40);

            Console.WriteLine("The great {0} , health {1}, attack {2}, block {3}", maximus.name, maximus.health, maximus.maxAttack, maximus.maxBlock);
            Console.WriteLine(" VS ");
            Console.WriteLine("The average {0} , health {1}, attack {2}, block {3}", bob.name, bob.health, bob.maxAttack, bob.maxBlock);

            //Console.WriteLine(new Warrior().name);
            Console.WriteLine("\n\nBegin Fight\n\n");


            Battle.StartFight(maximus, bob);
            Console.WriteLine("The great {0} , health {1}, attack {2}, block {3}", maximus.name, maximus.health, maximus.maxAttack, maximus.maxBlock);

        }
    }

    class Warrior
    {
        //Class variables
        public string name;
        public int health;
        public int maxAttack;
        public int maxBlock;

        public static Random randomGen = new Random();

        //Class Constructors
        public Warrior()
        {
            name = "Nameless";
            health = 100;
            maxAttack = 10;
            maxBlock = 5;
        }

        public Warrior(string _name, int _health, int _maxAttack, int _maxBlock)
        {
            name = _name;
            health = _health;
            maxAttack = _maxAttack;
            maxBlock = _maxBlock;
        }

        //Attack Method: Generate a random attack from 1 to the maximum attack value
        public int Attack()
        {
            int damage = randomGen.Next(maxAttack, maxAttack);
            return damage;
        }

        //Block Method: Generate a random block value from 1 to maximum block
        public int Block(int attackDamage)
        {
            int damageTaken = attackDamage - randomGen.Next(1, maxBlock);
            health -= damageTaken;
            return damageTaken;
        }

        

    }

    class Battle
    {
 
        public static void StartFight(Warrior fighter1, Warrior fighter2)
        {

            while (fighter1.health >= 0 && fighter2.health >= 0)
            {
                TakeTurn(fighter1, fighter2);
                if (Victorious(fighter1, fighter2))
                {
                    break;
                }

                TakeTurn(fighter2, fighter1);
                if (Victorious(fighter1, fighter2))
                {
                    break;
                }
            }

        }

        private static void TakeTurn(Warrior attacker, Warrior defender)
        {
            int attack = attacker.Attack();
            int damageTaken = defender.Block(attack);
            Console.WriteLine("{0} Attacks {1} and Deals {2} damage", attacker.name, defender.name, damageTaken);
            Console.WriteLine("{0} has {1} health\n", defender.name, defender.health);
        }

        private static bool Victorious(Warrior fighter1, Warrior fighter2)
        {
            if (fighter1.health <= 0)
            {
                Console.WriteLine("{0} is Victorius!!!", fighter2.name);
                return true;
            }
            if (fighter2.health <= 0)
            {
                Console.WriteLine("{0} is Victorius!!!", fighter1.name);
                return true;
            }
            return false;
        }
    }
}
