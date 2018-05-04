using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        interface IItem
        {
            string name { get; set; }
            int goldValue { get; set; }

            void Equip();
            void Sell();
        }

        interface IDamageable
        {
            int durability { get; set; }

            void TakeDamage(int _amount);
        }

        interface IPartOfQuest
        {
            void TurnIn();
        }

        class Sword : IItem, IDamageable, IPartOfQuest
        {
            public string name { get; set; }
            public int goldValue { get; set; }

            public int durability { get; set; }

            public Sword (string _name)
            {
                name = _name;
                goldValue = 100;
                durability = 50;
            }

            public void Equip()
            {
                Console.WriteLine(name + " has been equiped.");
            }

            public void Sell()
            {
                Console.WriteLine(name + " sold for " + goldValue);
            }

            public void TakeDamage (int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine("{0} took {1} damage. It now has a durability of {2}", name, _dmg, durability);
            }

            public void TurnIn()
            {
                Console.WriteLine("{0} was turned in. Quest reward received!", name);
            }
        }

        class Axe : IItem, IDamageable
        {
            public string name { get; set; }
            public int goldValue { get; set; }

            public int durability { get; set; }

            public Axe(string _name)
            {
                name = _name;
                goldValue = 70;
                durability = 25;
            }

            public void Equip()
            {
                Console.WriteLine(name + " has been equiped.");
            }

            public void Sell()
            {
                Console.WriteLine(name + " sold for " + goldValue);
            }

            public void TakeDamage(int _dmg)
            {
                durability -= _dmg;
                Console.WriteLine("{0} took {1} damage. It now has a durability of {2}", name, _dmg, durability);
            }
        }

        static void Main(string[] args)
        {
            Sword sword = new Sword("Sword of Destiny");
            sword.Equip();
            sword.TakeDamage(20);
            sword.Sell();

            Axe axe = new Axe("Plain Axe");
            axe.Equip();
            axe.TakeDamage(15);
            axe.Sell();

            //Create an inventory
            IItem[] inventory = new IItem[2];
            inventory[0] = sword;
            inventory[1] = axe;

            //Loop througn and turn in all quest items
            for (int i = 0; i < inventory.Length; i++)
            {
                IPartOfQuest questItem = inventory[i] as IPartOfQuest;
                if (questItem != null)
                {
                    questItem.TurnIn();
                }
            }

        }
    }
}
