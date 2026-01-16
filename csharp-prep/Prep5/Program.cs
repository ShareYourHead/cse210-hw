using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int n)
    {
        return (int)Math.Pow(n,2);
    }

    static void DisplayResult(string name, int n, int year)
    {
        int currentYear = 2026; //hardcoded
        int turning = currentYear-year;
        Console.WriteLine($"{name}, the square of your number is {n}");
        Console.WriteLine($"{name}, you will turn {turning} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        PromptUserBirthYear(out int year);
        int square = SquareNumber(number);
        DisplayResult(name, square, year);
    }
}