using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //numbers[0] = 4;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;
            ////numbers[5] = 123; will make an error



            int[] numbers = new int[] { 4, 8, 15, 16, 23, 34 };
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            numbers[7] = 123;

            string[] names = new string[] { "eddier", "alex", "michael", "joe" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string zig = "You should try to reverse this string";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char ch in charArray)
            {
                Console.Write(ch);
            }
        }
    }
}
