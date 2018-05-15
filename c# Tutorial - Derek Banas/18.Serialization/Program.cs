using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace _18.Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Save to binary
            Animal bowser = new Animal("Bowser", 45, 25);
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, bowser);
            stream.Close();

            bowser = null; //delete the bowser object

            //Load from Binary
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();
            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();
            Console.WriteLine(bowser);

            bowser.Weight = 50;

            //Save to XML
            string filepath = @"C:\Users\Pat\Documents\GitHub\csharp-tutorials\c# Tutorial - Derek Banas\18.Serialization\bowser.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(filepath))
            {
                serializer.Serialize(tw, bowser);
            }

            bowser = null;

            //Load from XML
            XmlSerializer deserialiszer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(filepath);
            object obj = deserialiszer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();

            Console.WriteLine(bowser);

            //Save a collection
            string filepath2 = "theAnimals.xml";
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 60, 61),
                new Animal("Luigi", 58, 59),
                new Animal("Peach", 45, 46),
                new Animal("Toad", 25, 26),
                new Animal("Wario", 80, 81),

            };

            using(Stream fs = new FileStream(filepath2, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }

            theAnimals = null;

            //Load a collection
            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using(FileStream fs2 = File.OpenRead(filepath2))
            {
                theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
            }

            foreach(Animal a in theAnimals)
            {
                Console.WriteLine(a);
            }
        }
    } //program class


    [Serializable()]
    public class Animal : ISerializable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal() { }

        public Animal(string name = "No Name",
            double weight = 0,
            double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} lbs and is {2} inches tall",
                Name, Weight, Height);
        }

        //Serialization function
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
        }
        

        //Deserialization function
        public Animal(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
        }
        

    } //animal class
} // namesopace
