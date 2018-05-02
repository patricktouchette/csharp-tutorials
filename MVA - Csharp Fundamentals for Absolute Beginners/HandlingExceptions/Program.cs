using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Pat\Documents\GitHub\csharp-tutorials\HandlingExceptions\Example.txt");
                Console.WriteLine(content);
            }

            catch (Exception ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //code ti finalize. Will run no matter what
                Console.WriteLine("Closing application");
            }

        }
    }
}
