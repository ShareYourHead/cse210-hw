using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        //Make events
        Lecture lecture = new Lecture("How to Ruin Your Life","Gain valuable insights into the destructive habits you never knew you had!","4/5/2026","10:30 AM","Skyridge High School","John MacEnroe",3000);
        Reception reception = new Reception("Anderson Couple's Reception","Celebrate Jack and Andi's wedding with cake and loud music!","12/25/2026","12:00 PM","Thanksgiving Point Gardens","loveshack@email.com");
        OutdoorGathering og = new OutdoorGathering("Picnic and Painting","We have food! We have art supplies! Bring a blanket and live your dreams!","9/11/3979","3:00 PM","Punnett Square Park","Sunny");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n\n");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n\n");
        Console.WriteLine(og.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(og.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(og.GetShortDescription());
    }
}