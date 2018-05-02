using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Random numberGenerator = new Random();
            int num01 = numberGenerator.Next(1,11);
            int num02 = numberGenerator.Next(1,11);

            int answer = num01 * num02;

            Console.WriteLine("What is {0} * {1}", num01, num02);
            int input = Convert.ToInt32(Console.ReadLine());

            if (answer == input){
                Console.WriteLine("You got it!");
            } else {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("Are you even trying? The answer was {0}", answer);
                        break;
                    case 2:
                        Console.WriteLine("Cmon man!? The answer was {0}", answer);
                        break;
                    case 3:
                        Console.WriteLine("That wasn't very good? The answer was {0}", answer);
                        break;
                    default:
                        Console.WriteLine("Are you even trying? The answer was {0}", answer);
                        break;
                }
                
            }
            goto Start;
        }
    }
}
