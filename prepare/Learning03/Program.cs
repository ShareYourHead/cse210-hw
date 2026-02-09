using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        /*
        //STEP 4
        Fraction a = new Fraction();
        Fraction b = new Fraction(6);
        Fraction c = new Fraction(6,7); //lol the instructions made an epic 67 reference
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(c.GetFractionString());
        //STEP 5
        Console.WriteLine();
        Console.WriteLine(a.GetTop());
        Console.WriteLine(a.GetBottom());
        a.SetTop(3);
        a.SetBottom(4);
        Console.WriteLine(a.GetFractionString());
        //STEP 6
        Console.WriteLine();
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());
        */
        //STEP 7
        Fraction frac = new Fraction();
        Random rng = new Random();
        for(int i = 1; i < 21; i++)
        {
            frac.SetTop(rng.Next(1, 11));
            frac.SetBottom(rng.Next(1, 11));
            Console.WriteLine($"Fraction {i}: string: {frac.GetFractionString()} Number: {frac.GetDecimalValue()}");
        }
    }
}