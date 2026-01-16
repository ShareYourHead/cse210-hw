using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        while (1==1)
        {
            Console.Write("Enter number: ");
            string inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);
            if (input != 0)
                numbers.Add(input);
            else
                break;
        }

        int sum = 0;
        int max = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            max = Math.Max(max, numbers[i]);
        }
        double avg = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");

        //test numbers: 18, 36, 2, 48, 6, 12, 9
    }
}