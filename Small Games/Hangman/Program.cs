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
            string[] words = "ant baboon badger bat bear beaver camel cat clam cobra cougar coyote crow deer dog donkey duck eagle ferret fox frog goat goose hawk lion lizard llama mole monkey moose mouse mule newt otter owl panda parrot pigeon python rabbit ram rat raven rhino salmon seal shark sheep skunk sloth snake spider stork swan tiger toad trout turkey turtle weasel whale wolf wombat zebra".Split(' ');
            List<string> wordsList = words.ToList();
            Console.WriteLine(wordsList[0]);

            string[] pics = HangManPics();
            PrintPics(pics);
            //Data data = new Data();
            //Console.WriteLine(pics[0]);
            //Console.WriteLine(pics[1]);
            //Console.WriteLine(pics.Length);

        }



        public static string[] HangManPics()
        {
            string[] pics = new string[3];
            pics[0] = @"
                      +---+
                      |   |
                          |
                          |
                          |
                          |
                    =========";
            pics[1] = @"
                      +---+
                      |   |
                          |
                          |
                          |
                          |
                    =========";
            pics[2] = "image";
       
            return pics;
        }

        public static void PrintPics(string[] pics)
        {
            Console.WriteLine(pics[0]);
            Console.WriteLine(pics[1]);

        }
    }





    class Data
    {
        //CLASS VARIABLES
        public string word;


        //CLASS CONSTRUTORS
        public Data(string _word)
        {
            word = _word;
        }

        //CLASS METHODS
        public void CreateData()
        {
            
        }

    }


}
