using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Conditionals_While_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero");

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine("An error occured");

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning Up");
            }

        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return (x / y);
        }

        static void NumberGame()
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;

            do
            {
                Console.WriteLine("Enter a number between 1 & 10: ");
                numberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuessed);
        }
    }
}
