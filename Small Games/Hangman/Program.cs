using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = "ant baboon badger bat bear beaver camel cat clam cobra cougar coyote crow deer dog donkey duck eagle ferret fox frog goat goose hawk lion lizard llama mole monkey moose mouse mule newt otter owl panda parrot pigeon python rabbit ram rat raven rhino salmon seal shark sheep skunk sloth snake spider stork swan tiger toad trout turkey turtle weasel whale wolf wombat zebra".Split(' ');
            //List<string> wordsList = words.ToList();

            //Console.WriteLine(wordsList[0]);
            Data data = new Data();
            Console.WriteLine(data.pics[0]);
            Console.WriteLine(data.pics.Length);
            Console.WriteLine(data.wordsList[0]);
            Console.WriteLine(data.wordsList.Count);
        }
    }

    class Data
    {
        static void CreateData()
        {
            private string[] words = "ant baboon badger bat bear beaver camel cat clam cobra cougar coyote crow deer dog donkey duck eagle ferret fox frog goat goose hawk lion lizard llama mole monkey moose mouse mule newt otter owl panda parrot pigeon python rabbit ram rat raven rhino salmon seal shark sheep skunk sloth snake spider stork swan tiger toad trout turkey turtle weasel whale wolf wombat zebra".Split(' ');
            public List<string> wordsList = words.ToList();
            //public List<string> words = new List<string>() { "Test", "one", "two" };
            public string[] pics = new string[3] {
                    @"
                    +---+
                    |   |
                        |
                        |
                        |
                        |
                  =========",
                    "2", "3" };
        }
    }


}
