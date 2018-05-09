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
            //1. Pass by Value
            double x = 5;
            double y = 4;
            Console.WriteLine("1. Pass by Value");
            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));
            Console.WriteLine("x {0} \n", x);

            //2. Using the out parameter
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("2. OUT parameter:");
            Console.WriteLine(" 15 * 2 = {0}\n", solution);

            //3. Pass by reference
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("3. Pass by reference");
            Console.WriteLine("Before Swap num1: {0}, num2: {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After Swap num1: {0}, num2: {1}\n", num1, num2);

            //4. Params
            Console.WriteLine("4. Params");
            Console.WriteLine("1+2+3 = {0}", GetSumMore(1, 2, 3));
            double[] nums = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("1+2+3+4+5+6 = {0}\n", GetSumMore(nums));

            //5. NAmed Parameters 
            PrintInfo(ZipCode: 12345, name: "Patrick T");

            //6. Method Overload
            Console.WriteLine("5.0 + 4.5 = {0}", GetSumOverload(5.0, 4.5));
            Console.WriteLine("5 + 4 = {0}", GetSumOverload(5, 4));
            Console.WriteLine("'5' + '4' = {0}\n", GetSumOverload("5", "4"));

            //7. ENUMS
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);

        }

        //1. pass by value example
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;

            return x + y;
        }

        //2. Out parameter
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        //3. Pass by reference
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        //4. Params
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums) {
                sum += i;
            }
            return sum;
        }

        //5. NAmed Parameters 
        static void PrintInfo(string name, int ZipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, ZipCode);
        }

        //6. Method Overload
        static double GetSumOverload(double x = 1, double y = 1)
        {
            return x + y;
        }
        static double GetSumOverload(string x = "1", string y = "1")
        {
            double dblx = Convert.ToDouble(x);
            double dbly = Convert.ToDouble(y);
            return dblx + dbly;
        }

        //7.Enums
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}", cc, (int)cc);
        }
    }
}
