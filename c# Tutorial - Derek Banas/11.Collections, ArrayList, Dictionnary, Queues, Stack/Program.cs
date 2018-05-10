using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _11.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            #region ArrayList Code

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            PrintArray(aList, "aList");
            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Make", "Sally", "Egg" });
            PrintArray(aList2, "aList2");


            aList.AddRange(aList2);         PrintArray(aList, "Combined aList + aList2");
            aList2.Sort();                  PrintArray(aList2, "aList2 Sorted: ");
            aList2.Reverse();               PrintArray(aList2, "aList2 Reversed: ");
            aList2.Insert(1, "Turkey");     PrintArray(aList2, "aList2 turkey insert: ");

            ArrayList range = aList2.GetRange(0, 2); PrintArray(range, "Range 0-2 from aList2");

            aList2.RemoveAt(0);             PrintArray(aList2, "removed 0: ");
            Console.WriteLine("Turkey Index: {0}", aList2.IndexOf("Turkey", 0));

            //Convert ArrayList to  Array
            string[] myArray =  (string[])aList2.ToArray(typeof(string));

            //Convert Array to ArrayList
            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);  PrintArray(custArrayList, "custArrayList: ");

            #endregion


            //Dictionnaries
            Console.WriteLine("\n\n\nDictionnaries");
            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry West", "Flash");

            superheroes.Remove("Barry West");
            Console.WriteLine("Count: {0}", superheroes.Count);
            Console.WriteLine("Clark Kent: {0}", superheroes.ContainsKey("Clark Kent"));
            superheroes.TryGetValue("Clark Kent", out string test);

            Console.WriteLine("Clark Kent tryGetValue: {0} ", test);
            Console.WriteLine(superheroes["Clark Kent"]);
            //Console.WriteLine(superheroes["Clark Kentwer"]); //This will make the program crash

            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            //Delete everything in the dictionnary
            superheroes.Clear();


            //QUEUES
            Console.WriteLine("\n\n\nQueues");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(7);
            queue.Enqueue(10);

            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
            Console.WriteLine("Remove 1 in Queue : {0}", queue.Dequeue());
            Console.WriteLine("Peek first item in Queue : {0}", queue.Peek());

            object[] numArray = queue.ToArray();
            Console.WriteLine(string.Join(", ", numArray));

            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }

            queue.Clear();

            //STACKS
            Console.WriteLine("\n\n\nStacks");
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            PrintStack(stack, "stack");
            Console.WriteLine("Peek 1: {0}", stack.Peek());
            Console.WriteLine("Pop 1: {0}", stack.Pop());
            PrintStack(stack, "stack");
            Console.WriteLine("Contains 1: {0}", stack.Contains(1));

            object[] numArray2 = stack.ToArray();

            Console.WriteLine(string.Join(", ", numArray2));

            stack.Clear();

        }

        static void PrintArray(ArrayList aList, string name)
        {
            Console.Write(name + ":");
            foreach (object item in aList)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        static void PrintStack(Stack stack, string name)
        {
            Console.Write(name + ":");
            foreach (object item in stack)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
