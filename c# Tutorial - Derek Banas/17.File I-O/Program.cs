using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17.File_I_O
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            Console.WriteLine(currDir.FullName);
            Console.WriteLine(currDir.Parent);
            Console.WriteLine(currDir.Attributes);
            Console.WriteLine(currDir.CreationTime);

            DirectoryInfo myDir = new DirectoryInfo(@"C:\Users\Pat\Documents\GitHub");
            Console.WriteLine(myDir.Name);

            //DirectoryInfo dataDir = new DirectoryInfo(@".\c#Data");
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Pat\Documents\GitHub\csharp-tutorials\c# Tutorial - Derek Banas\17.File I-O\c#Data");
            dataDir.Create();

            string[] customers =
            {
                "Bob Smith", "Sally Smith", "Robert Smith"
            };

            string textFilePath = @"C:\Users\Pat\Documents\GitHub\csharp-tutorials\c# Tutorial - Derek Banas\17.File I-O\c#Data\testfile1.txt";
            File.WriteAllLines(textFilePath, customers);

            foreach(string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customer : {cust}");
            };

            FileInfo[] txtFiles = dataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Matches: {0}", txtFiles.Length); 
            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);

            }

            //Filestream
            string textFilePath2 = @"C:\Users\Pat\Documents\GitHub\csharp-tutorials\c# Tutorial - Derek Banas\17.File I-O\c#Data\testfile2.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);

            string randString = "This is a random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);
            fs.Write(rsByteArray, 0, rsByteArray.Length);

            fs.Position = 0;

            byte[] fileByteArray = new byte[rsByteArray.Length];
            for(int i =0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();

            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();

            //StreamWriter and StreamReader
            string textFilePath3 = @"C:\Users\Pat\Documents\GitHub\csharp-tutorials\c# Tutorial - Derek Banas\17.File I-O\c#Data\testfile3.txt";

            StreamWriter sw = File.CreateText(textFilePath3);
            sw.Write("This is a random");
            sw.WriteLine("Sentence");
            sw.WriteLine("This is another Sentence");
            sw.WriteLine("This is another Sentence");
            sw.WriteLine("This is another Sentence");
            sw.WriteLine("This is another Sentence");

            sw.Close();
            StreamReader sr = File.OpenText(textFilePath3);
            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st string: {0}", sr.ReadLine());
            Console.WriteLine("Everything: {0}", sr.ReadToEnd());
            sr.Close();

            //BinaryWriter and BinaryReader
            string textFilePath4 = @"C:\Users\Pat\Documents\GitHub\csharp-tutorials\c# Tutorial - Derek Banas\17.File I-O\c#Data\testfile4.dat";

            FileInfo datFile = new FileInfo(textFilePath4);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());

            string randText = "Random Text and all sorts of stuff";
            int myAge = 28;
            double height = 6.25;

            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);

            bw.Close();

            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();

        }
    }
}
