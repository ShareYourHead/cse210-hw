using System;
using Develop03;

// * * * * *
//
// To exceed requirements, I added a "show all" function.
// I also made it so that the program does not hide the punctuation when its adjacent word is hidden.
//
// * * * * *

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new("Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.", "Proverbs", 3, 5, 6);
        
        string text = "";
        while(text.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.Display());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, type 'show' to restart, or type 'quit' to finish:");
            text = Console.ReadLine();
            if(text.ToLower() == "show")
            {
                scripture.ShowAll();
                continue;
            }
            if(!scripture.HideWords(3))
                break;
        }
    }
}