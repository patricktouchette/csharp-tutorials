using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();
            int numberOfAttempts = 0;
            int attempt = 0;
            
            while (attempt != 6)
            {
                attempt = numberGenerator.Next(1, 7);
                numberOfAttempts++;
                Console.WriteLine("Tom rolled a : " + attempt);
            }
            Console.WriteLine("It took Tom " + numberOfAttempts + " attemps to roll a six.");
        }
    }
}
