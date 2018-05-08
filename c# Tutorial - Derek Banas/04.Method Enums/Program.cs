using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Method_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution;

            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}", solution);
        }

        static void test()
        {
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));

            Console.WriteLine("x {0}", x);
        }

        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;

            return x + y;
        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
}
