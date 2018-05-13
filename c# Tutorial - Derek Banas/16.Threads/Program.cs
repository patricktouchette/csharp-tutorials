using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Two simple Threads
                Thread t1 = new Thread(Print1);
                Thread t0 = new Thread(Print0);

            //t1.Start();
            //t0.Start();

            //2. Thread Sleep
            //ThreadSleep();

            //3. Thread Lock
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";

            for(int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine( "Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
            }

            Console.WriteLine("Current Priority: {0}", Thread.CurrentThread.Priority);
            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

            //4.Pass data to a thread using Lambda expressions
            Console.WriteLine("\n\nPass data to threads");
            Thread t2 = new Thread(() => CountTo(10));
            t2.Start();

            new Thread(() =>
            {
                CountTo(5);
                CountTo(7);
            }).Start();


        }

        //1. Two Threads
        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }

        static void Print0()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
        }

        //2.Thread Sleep
        static void ThreadSleep()
        {
            int num = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Thread Ends");
        }

        //4.Pass data to a thread using Lambda expressions
        static void CountTo(int maxNum)
        {
            for(int i = 0; i <= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    //3. Thread Lock
    class BankAcct
    {
        private Object acctLock = new object();
        double Balance { set; get; }

        public BankAcct(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {
            if((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account" );
                return Balance;
            }

            lock (acctLock)
            {
                if(Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
                    Balance -= amt;
                }
                return Balance;
            }
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }
        
    }

}
