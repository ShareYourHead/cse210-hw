using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Activity(string name, string description)
    {
        private string _activityName = name;
        private string _activityDescription = description;
        private int _activityDuration;

        public int GetDuration()
        {
            return _activityDuration;
        }

        public void StartMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_activityName}.\n");
            Console.WriteLine($"{_activityDescription}\n");
            Console.Write("How long, in seconds, would you like for your session? ");
            _activityDuration = int.Parse(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("Get ready...");
            PauseSpinner();
            Console.WriteLine();
        }

        public void EndMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            PauseSpinner();
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}.");
            PauseSpinner();
        }

        public void PauseSpinner(int pauseDuration = 5)
        {
            char[] frames = ['/','-','\\','|'];
            int iterations = pauseDuration * 4;
            for (int i = 0; i < iterations; i++)
            {
                Console.Write(frames[i%4]);
                Thread.Sleep(1000/4);
                Console.Write("\b \b");
            }
        }

        public void Countdown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public string GetRandomPrompt(List<string> promptList)
        {
            return promptList[Random.Shared.Next(promptList.Count)];
        }

        public void DisplayPrompt(string prompt)
        {
            Console.WriteLine($" --- {prompt} --- ");
        }
    }
}
