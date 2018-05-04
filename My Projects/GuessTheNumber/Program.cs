//Guess the number game
//@author: Patrick Touchette

//Concepts reviewed
//While loops, functions, Error Handling
//Data types: string, int, bool, random, Int32.Parse (to parse int to string)
//Logical operators: &, |
//Relational Operators: !=, ==, >, >= , etc...
//Assignment operators: =, +=, -=

using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                MainMenu();
                playing = GuessingGame();
            } 
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the Guessing Game");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static bool GuessingGame()
        {
            int numberOfGuesses = 5;
            Random rnd = new Random();
            int number = rnd.Next(1, 6);
            bool incorrect = true;

            while (numberOfGuesses >= 0 & incorrect)
            {
                Console.WriteLine("Guess a number between 1 and 5: ");
                string input = Console.ReadLine();
                bool CheckedInput = CheckInput(input);
                if (CheckedInput == false)
                    continue;

                Int32.Parse(input);
                numberOfGuesses -= 1;
                if (Int32.Parse(input) == number)
                {
                    Console.WriteLine("You guessed it. The number was " + number + "\n");
                    incorrect = false;
                    bool again = PlayAgain();
                    return again;
                }

                if (Int32.Parse(input) != number)
                {
                    Console.WriteLine("WRONG! You have {0} guesses left \n", numberOfGuesses);
                }
            }
            return true;
        }

        private static bool CheckInput(string input)
        {
            try
            {
                if (Int32.Parse(input) <= 5)
                {
                    return true;
                }
                else if (Int32.Parse(input) > 5)
                {
                    Console.WriteLine("Number was way to high");
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a valid number ");
                return false;
            }
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again? Y or N");
            string again = Console.ReadLine().ToUpper();

            if (again == "Y" || again == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
