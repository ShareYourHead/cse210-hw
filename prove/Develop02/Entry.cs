using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace Develop02
{
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