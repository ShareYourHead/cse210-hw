using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace JournalObjects
{
    public class PromptGenerator
    {
        private List<string> prompts = new List<string>();
        private Random rng = new Random();

        public PromptGenerator(string path = "prompts")
        {
            if(!File.Exists(path))
            {
                Console.WriteLine($"ERROR! \"{path}\" not found.");
                return;
            }

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string prompt = reader.ReadLine();
                    prompts.Add(prompt);
                }
            }
            
            return; //skip printing stuff

            foreach(string prompt in prompts)
            {
                Console.Write("IMPORTED PROMPT: ");
                Console.WriteLine(prompt);
            }
            Console.WriteLine();
        }

        public int GeneratePrompt()
        {
            return rng.Next(0, prompts.Count);
        }

        public void Display(int n, bool line = true)
        {
            Console.Write(prompts[n]);
            if(line)
            {
                Console.WriteLine();
            }
        }
    }

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

    public class Entry
    {
        private Journal parent;
        public string date = "M/d/yyyy";
        public int prompt;
        public string content;

        public Entry(Journal j, int i, string s)
        {
            parent = j;
            date = DateTime.Now.ToString("M/d/yyyy");
            prompt = i;
            content = s;
        }

        public Entry(Journal j, string d, int i, string s)
        {
            parent = j;
            date = d;
            prompt = i;
            content = s;
        }

        public void Display()
        {
            Console.Write($"Date: {date} - Prompt: ");
            parent.pg.Display(prompt);
            Console.WriteLine(content);
            Console.WriteLine();
        }
    }
}