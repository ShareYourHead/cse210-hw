using System;
using System.Collections.Generic;

namespace Develop04
{
    public class ListingActivity() : Activity(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    {
        private int _userCounter;

        private List<string> _promptsListListing()
        {
            return new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Spirit this month?",
                "Who are some of your personal heroes?"
            };
        }

        public void Run()
        {
            StartMessage();

            Console.WriteLine("List as many responses as you can to the following prompt:");
            DisplayPrompt(GetRandomPrompt(_promptsListListing()));
            Console.Write("You may begin in: ");
            Countdown(5);
            Console.WriteLine();

            int listed = 0;

            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string line = Console.ReadLine();
                if(line != "") listed++;
            }
            Console.WriteLine($"You listed {listed} items!");

            EndMessage();
        }
    }
}
