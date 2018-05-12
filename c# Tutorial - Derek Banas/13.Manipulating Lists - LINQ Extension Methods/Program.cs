using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Manipulating_Lists___LINQ_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //LAMBDAS
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");


            //get even numbers
            List<int> numList = new List<int> { 1, 9, 2, 6, 3 };
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var j in evenList) Console.Write(j + " "); Console.WriteLine();

            //get range
            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();
            foreach (var j in rangeList) Console.Write(j + " "); Console.WriteLine();

            //Find number of heads and tails flipped randomly
            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while(i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }
            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count());

            //Find all names that start with a specific letter
            var nameList = new List<string> { "Doug", "Sally", "Sue" };
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach (var j in sNameList) Console.Write(j + " "); Console.WriteLine();

            //SELECT
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));

            var squares = oneTo10.Select(x => x * x);
            foreach (var j in squares) Console.Write(j + " "); Console.WriteLine();

            //ZIP
            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4,6,8  });
            var sumList = listOne.Zip(listTwo, (x,y) => x*10 + y).ToList();
            foreach (var j in sumList) Console.Write(j + " "); Console.WriteLine();

            //Aggregate
            var numList2 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Sum : {0}", numList2.Aggregate((a,b) => a +b));

            //Average
            Console.WriteLine("Avg: {0}", numList2.AsQueryable().Average());

            //All
            Console.WriteLine("All > 3: {0}", numList2.All(x => x > 3));

            //Distinct
            var numList3 = new List<int> { 1, 2, 3, 2, 3 };
            Console.WriteLine("Distint : {0}", string.Join(",", numList3.Distinct()));

            //Except - takes two lists and returns values that aren't found in the second list
            var numList4 = new List<int> {3 };
            Console.WriteLine("Except : {0}", string.Join(",", numList3.Except(numList4)));

            //Intersect - returns values found in both lists
            Console.WriteLine("Intersect : {0}", string.Join(",", numList3.Intersect(numList4)));
        }

        delegate double doubleIt(double val);
    }
}
