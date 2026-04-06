using System;
using System.Threading;

namespace Develop04
{
    public class BreathingActivity() : Activity(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
    )
    {
        public void Run()
        {
            void PopulateText(string text, int ms)
            {
                int len = text.Length;
                for(int i = 0; i < len; i++)
                {
                    Console.Write(text[i]);
                    if(i==len-1)
                        Thread.Sleep(ms%len); //last character
                    else
                        Thread.Sleep(ms/len); //not last character
                }
            }

            void LeftToRightWipe(string text, int ms)
            {
                //Assumes that text is already populated
                int len = text.Length;
                for(int i = 0; i < len; i++)
                {
                    Console.Write('\r'); //Clear last line
                    for(int j = 0; j < len; j++)
                    {
                        if(j>i)
                            Console.Write(text[j]);
                        else
                            Console.Write(' ');
                    }
                    if(i==len-1)
                        Thread.Sleep(ms%len); //last character
                    else
                        Thread.Sleep(ms/len); //not last character
                }
                Console.Write('\r'); //Clear last line
            }

            void RightToLeftWipe(string text, int ms)
            {
                //Assumes that text is already populated
                int len = text.Length;
                for(int i = 0; i < len; i++)
                {
                    Console.Write("\b \b");
                    if(i==len-1)
                        Thread.Sleep(ms%len); //last character
                    else
                        Thread.Sleep(ms/len); //not last character
                }
                Console.Write('\r'); //Clear last line
            }

            StartMessage();
            Console.Clear();
            Console.WriteLine();
            
            //string[] phases = ["Breathe in...", "Now breathe out..."];
            //int[] times = [2000,3000];
            int factor = 1;

            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
            while (DateTime.Now < endTime)
            {
                //breathe in phase 2000ms initially then 4000ms
                PopulateText("Breathe in...",500*factor*factor);
                if(factor==1) Thread.Sleep(500);
                LeftToRightWipe("Breathe in...",1000*factor);

                //breathe out phase 3000ms initially then 6000ms
                PopulateText("Now breathe out...",500*factor*factor);
                if(factor==1) Thread.Sleep(500);
                RightToLeftWipe("Now breathe out...",2000*factor);

                factor = 2;
            }
            
            Console.Clear();
            EndMessage();
        }

        /*
        public void Run()
        {
            StartMessage();
            
            string[] phases = ["Breathe in...", "Now breathe out..."];
            int[] times = [2,3];

            DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
            while (DateTime.Now < endTime)
            {
                Console.WriteLine();
                for(int i = 0; i < 2; i++)
                {
                    Console.Write(phases[i]);
                    Countdown(times[i]);
                    Console.WriteLine();
                }
                times = [4,6];
            }
            
            EndMessage();
        }
        */
    }
}
