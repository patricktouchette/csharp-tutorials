using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02.Looping_Arrays_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] favNums = new int[3];
            favNums[0] = 23;

            Console.WriteLine("favNum 0: {0}", favNums[0]);

            string[] customers = { "Bob", "Sally", "sue" };

            object[] randomArray = { "Paul", 45, 1.234 };

            Console.WriteLine("randomArray 0 {0}", randomArray[0].GetType());

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}", i, randomArray[i]);
            }

            //Multidimensional array
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Marks" } };
            Console.WriteLine("MD Value : {0}", custNames.GetValue(1, 1));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(0); j++)
                {
                    Console.Write("{0}", custNames[i, j]);
                }
                Console.WriteLine();
            }

            //Sort array
            int[] randNums = { 1, 4, 9, 2 };
            Array.Sort(randNums);
            Array.Reverse(randNums);

            PrintArray(randNums, "ForEach");
            Console.WriteLine("1 at Index : {0}, ", Array.IndexOf(randNums, 1));

            randNums.SetValue(13, 0);
            PrintArray(randNums, "forEach");

            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray, startInd, length);
            PrintArray(destArray, "Copy");


            //String builder
            StringBuilder sb = new StringBuilder(" Random Text");
            StringBuilder sb2 = new StringBuilder("More stuff that is important", 256);

            Console.WriteLine("capacity : {0}", sb.Capacity);
            Console.WriteLine("capacity : {0}", sb2.Capacity);

            sb2.AppendLine("\n More important text");

            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer : {0}", bestCust);

            Console.WriteLine(sb2.ToString());

            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());



            Console.ReadLine();

        }


        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }
    }
}
