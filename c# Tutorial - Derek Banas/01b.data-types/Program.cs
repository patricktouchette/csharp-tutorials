using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01b.data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canIVote = true;

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Biggest Long : {0}", long.MinValue);

            decimal decPiVal = 3.1415926M;
            decimal decBigNum = 2.000000000000000000000011M;
            Console.WriteLine("DEC : Pi + bigNum = {0}", decPiVal + decBigNum);

            double dbl = 3.1412123123123;

            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double doubleFromstr = double.Parse("1.234");

            // DATETIME
            DateTime date = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of the week: {0}", date.DayOfWeek);

            date = date.AddDays(3);
            date = date.AddMonths(4);
            date = date.AddYears(2);

            Console.WriteLine("new date: {0}", date.Date);

            //TIMESPAN
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time : {0}", lunchTime.ToString());

            //number formating
            Console.WriteLine("Currency: {0:c}", 23.455);
            Console.WriteLine("Pad with 4 zeroes: {0:d4}", 23);
            Console.WriteLine("3 decimals: {0:f3}", 23.4555);
            Console.WriteLine("Commas: {0:n2}", 2300);

            //Strings
            string randString = "This is a astring";
            Console.WriteLine("Length {0}", randString.Length);
            Console.WriteLine("Constains {0}", randString.Contains("is"));
            Console.WriteLine("index of is {0}", randString.IndexOf("is"));
            Console.WriteLine("remove {0}", randString.Remove(0,6));
            Console.WriteLine("insert {0}", randString.Insert(10, "short "));
            Console.WriteLine("replace {0}", randString.Replace("string", "sentence"));
            Console.WriteLine("compare A to B {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));




        }
    }
}
