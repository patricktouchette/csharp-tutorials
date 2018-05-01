using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for for var K: " + k);
            HelperMethod();
        }

        static void HelperMethod()
        {
            Console.WriteLine("this is the value of k from the helpermethod:" + k);
        }
    }
}
