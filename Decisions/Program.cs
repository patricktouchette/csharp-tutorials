﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bob's Big Giveaway");
            //Console.WriteLine("Choose a door: 1, 2, 3: ");
            //string userValue = Console.ReadLine();

            //string message;

            //if (userValue == "1")
            //    message = "You won a new car!";

            //else if (userValue == "2")
            //    message = "You won a new boat!";

            //else if (userValue == "3")
            //    message = "You won a new cat!";

            //else
            //{
            //    message = "Sorry we didn't understand";
            //    message += 'You lose.'
            //}
            //Console.WriteLine(message);
            //Console.ReadLine();

            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.Write("You won a {0}.", message);
            Console.ReadLine();
        }
    }
}
