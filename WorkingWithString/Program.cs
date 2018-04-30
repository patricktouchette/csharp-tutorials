using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "enter\n \ttab \\backslash";
            myString = @"go to your c:\ drive";
            myString = string.Format("{0:C}", 123.45);
            myString = string.Format("Percentage: {0:P}", .123);
            myString = string.Format("Phone Number: {0:(###) ###-####}", 4506494754);

            myString = " That summer we took threes across the board ";
            myString = myString.Trim();
            myString = myString.Substring(6);
            myString = myString.Substring(6, 14);
            myString = myString.ToUpper();
            myString = myString.Replace(" ", "--");
            myString = myString.Remove(4, 12);

            myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }

            StringBuilder myStringBuilder = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myStringBuilder.Append("--");
                myStringBuilder.Append(i);
            }

            myString = string.Format("{0} - {1}", "3", "4", "5");
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
