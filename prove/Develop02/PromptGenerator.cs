using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace Develop02
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
}