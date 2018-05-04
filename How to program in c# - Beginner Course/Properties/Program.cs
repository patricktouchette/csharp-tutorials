using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Player
    {
        private int _health = 100;

        public int health // or  public int health { get {return _health; } }
        {
            get
            {
                return _health;
            }
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                }
                else if (value >= 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
                    
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player tom = new Player();
            Console.WriteLine(tom.health);
            tom.health -= 300;
            Console.WriteLine(tom.health);
            tom.health += 400;
            Console.WriteLine(tom.health);
            tom.health = 40;
            Console.WriteLine(tom.health);

        }
    }
}
