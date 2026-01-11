using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeStr = Console.ReadLine();
        float grade = float.Parse(gradeStr);



        string letter = string.Empty;

        if (grade >= 90.0)
            letter = "A";
        else if (grade >= 80.0)
            letter = "B";
        else if (grade >= 70.0)
            letter = "C";
        else if (grade >= 60.0)
            letter = "D";
        else
            letter = "F";

        Console.WriteLine($"Your grade: {letter}");



        if(grade >= 70.0)
            Console.WriteLine("Congratulations on the passing grade!");
        else
            Console.WriteLine("DO CREDIT FOR YOU! Start fresh next semester.");

    }
}