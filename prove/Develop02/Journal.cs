using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace Develop02
{
    public class Journal
    {
        public PromptGenerator pg;
        public List<Entry> entries = new List<Entry>();

        public Journal(PromptGenerator promptGenerator)
        {
            pg = promptGenerator;
        }

        public void Write()
        {
            int prompt = pg.GeneratePrompt();
            pg.Display(prompt);

            Console.Write("> ");
            string content = Console.ReadLine();

            Entry newEntry = new Entry(this, prompt, content);
            entries.Add(newEntry);
        }

        public void Display()
        {
            foreach(Entry entry in entries)
            {
                entry.Display();
            }
        }

        public void Load()
        {
            Console.WriteLine("What is the filename?");
            string path = Console.ReadLine();
            
            if(!File.Exists(path))
            {
                Console.WriteLine($"ERROR! \"{path}\" not found.");
                return;
            }

            entries = new List<Entry>();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split("~|~");

                    Entry newEntry = new Entry(this, parts[0], int.Parse(parts[1]), parts[2]);
                    entries.Add(newEntry);
                }
            }
            
            return;
        }

        public void Save()
        {
            Console.WriteLine("What is the filename?");
            string path = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach(Entry entry in entries)
                {
                    writer.WriteLine(string.Join("~|~",entry.date,entry.prompt,entry.content));
                }
            }
        }

        public void Merge()
        {
            Console.WriteLine("What is the primary filename?");
            string pathA = Console.ReadLine();

            if(!File.Exists(pathA))
            {
                Console.WriteLine($"ERROR! \"{pathA}\" not found.");
                return;
            }

            Console.WriteLine($"What is the filename for the file you would like to merge into {pathA}?");
            string pathB = Console.ReadLine();

            if(!File.Exists(pathB))
            {
                Console.WriteLine($"ERROR! \"{pathB}\" not found.");
                return;
            }

            using (var reader = new StreamReader(pathB))
            {
                using (StreamWriter writer = new StreamWriter(pathA, true))
                {
                    while (!reader.EndOfStream)
                    {
                        writer.WriteLine(reader.ReadLine());
                    }
                }
            }
        }
    }
}