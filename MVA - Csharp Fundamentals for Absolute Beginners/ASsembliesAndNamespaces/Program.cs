using System;
using System.IO;
using System.Net;

namespace ASsembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "THis is some text to save to a file";
            //System.IO.File.WriteAllText(@"C:\Users\Pat\Documents\GitHub\csharp-tutorials\ASsembliesAndNamespaces\writetext.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://patricktouchette.github.io/");

            System.IO.File.WriteAllText(@"C:\Users\Pat\Documents\GitHub\csharp-tutorials\ASsembliesAndNamespaces\writetext.txt", reply);


            Console.WriteLine(reply);
        }
    }
}
