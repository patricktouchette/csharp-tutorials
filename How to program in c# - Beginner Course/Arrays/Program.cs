using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            int[] numbers = new int[5];
            numbers[0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;

            Console.WriteLine(numbers[0]);

            for (int i=0; i< numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine('\n');

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            string[] names = new String[3]
            {
                "Thom", "Mark", "Matt"
            };
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            //Lists
            List<int> numbers2 = new List<int>();
            numbers2.Add(13);
            numbers2.Add(4);
            numbers2.Add(8);
            numbers2.Remove(13);

            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.Write(numbers2[i] + " ");
            }
            Console.WriteLine('\n');

            //Multi-dimensionnal array
            CreateGrid();

        }

        //Multi-dimensionnal array
        public static void CreateGrid()
        {
            int width = 10;
            int height = 10;

            int[,] grid = new int[width, height];
            grid[2, 3] = 3;

            for (int x=0; x < width; x++)
            {
                for (int y=0; y < height; y++)
                {
                    grid[x, y] = x + y;
                    Console.Write(grid[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
