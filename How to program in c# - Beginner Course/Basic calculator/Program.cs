using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            double num01;
            double num02;

            Console.WriteLine("Write a number to be multiplied");
            num01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write another number to be multiplied");
            num02 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The result is " + num01 * num02 + "\n");
            Console.WriteLine("Press any key to Continue");
            Console.ReadLine();
            Console.Clear();
            goto Start; //Jumps to start


        }
    }
}
