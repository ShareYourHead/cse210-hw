using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int target = randomGenerator.Next(1, 101);
        
        //Console.WriteLine($"What is the magic number? {target}");
        
        Console.WriteLine("What is the magic number?");
        
        int guess = -1; //Wow the example solution did the same -1 thing! I'm a genius.

        while (guess!=target)
        {
            Console.Write("What is your guess? ");
            string guessStr = Console.ReadLine();
            guess = int.Parse(guessStr);

            if (guess < target)
                Console.WriteLine("Higher");
            else if (guess > target)
                Console.WriteLine("Lower");
            else
                Console.WriteLine("You guessed it!");
        }
    }
}