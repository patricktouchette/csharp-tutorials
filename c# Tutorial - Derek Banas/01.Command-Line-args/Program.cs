using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Command_Line_args
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow Word");
            for (int i = 0; i < args.Length; i++)
            {
                //Set arguments by opening command-Line-args properties, then go to debug /start options 
                // command line argumgents
                Console.WriteLine("Arg {0} : {1}", args[i], i);
            }

            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));
            Console.WriteLine(myArgs[0]);

            //Calling function
            SayHello();
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }

}
