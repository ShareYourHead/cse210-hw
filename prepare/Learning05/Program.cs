using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new("Burgundy", 2);
        Rectangle rect = new("Charteuse", 9, 12);
        Circle cir = new("Puce", 3);

        List<Shape> shapes = [sq, rect, cir];

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}