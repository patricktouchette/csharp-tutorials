using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SOLID_Design_Principles
{
    class SingleResponsibilityPrinciple
    {
        public SingleResponsibilityPrinciple()
        {
            var j = new Journal();
            j.AddEntry("First entry");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            var p = new Persistance();
            var filename = @"journal.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(filename);

        }
    }

    public class Journal
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; //memento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        /*Let's say we want to add persistance to this Journal class,
         * we could add these functions.
         * However this violates the single responsibility principle.
         * We should instead create a new class to handle persistance.
         * The journal class should only take care of it's entries, and not how they are saved
        
        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        public static Journal Load(string filename)
        {

        }

        public void Load(Uri uri)
        {

        }
        */
    }

    //To handle the persistance, we should use a new class
    public class Persistance
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, j.ToString());
        }
    }

}
