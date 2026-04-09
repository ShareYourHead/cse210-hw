using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Trip Whimsworth", "Seize the means of production");
        MathAssignment b = new MathAssignment("Galadriel Moonchild", "Calculus homework", "6.7", "7,8,9");
        WritingAssignment c = new WritingAssignment("Albert Camus", "Philosophy", "The Myth of Sisyphus");

        Console.WriteLine(a.GetSummary());

        Console.WriteLine(b.GetSummary());
        Console.WriteLine(b.GetHomeworkList());

        Console.WriteLine(c.GetSummary());
        Console.WriteLine(c.GetWritingInformation());
    }
}
