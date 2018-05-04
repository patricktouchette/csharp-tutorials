using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 42);
            meaning.Print();

            //Creating a Dictionary
            Dictionary<string, int> prices = new Dictionary<string, int>(5);
            prices.Add("Watermelon", 5);
            prices.Add("Car", 10000);
            Console.WriteLine(prices["Watermelon"]);
            Console.WriteLine();

            //utility class
            Console.WriteLine(Utility.CompareValue(10, 3));
            Console.WriteLine(Utility.CompareValue(10, 10));
            Console.WriteLine(Utility.CompareTypes(10, 22.65));
        }
    }


    //Creating a keyValue pair generic
    class KeyValuePair<TKey, TValue>
    {
        public TKey key;
        public TValue value;

        public KeyValuePair(TKey _key, TValue _value)
        {
            key = _key;
            value = _value;
        }

        public void Print()
        {
            Console.WriteLine("Key: " + key.ToString());
            Console.WriteLine("Value: " + value.ToString());
        }
    }

    class Utility
    {
        public static bool CompareValue<T01, T02> (T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }

        public static bool CompareTypes<T01, T02>(T01 type01, T02 type02)
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }
}
