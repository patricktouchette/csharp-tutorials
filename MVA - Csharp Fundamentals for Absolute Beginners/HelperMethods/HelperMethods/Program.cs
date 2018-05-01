using System;


namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

        
            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            DisplayResult(reversedFirstName, reversedLastName, reversedCity);
            DisplayResult(reversedFirstName + reversedLastName + reversedCity);


        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string reversedFirstName,
               string reversedLastName,
               string reversedCity)
        {
            Console.WriteLine("Results: ");
            Console.Write(string.Format("{0} {1} {2}",
            reversedFirstName,
            reversedLastName,
            reversedCity));
            Console.WriteLine("\n");
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine("Results: ");
            Console.Write(message);
        }
    }
}
