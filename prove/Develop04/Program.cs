using System;
using Develop04;

// * * * * *
//
// To exceed requirements, I made the breathing activity fully animated.
// I accomplished this by adding 3 submethods to run() in BreathingActivity.cs
// and entirely rewriting it. The original run() is included also, just commented out.
//
// * * * * *

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflecting Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
