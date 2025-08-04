using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the first side of the triangle: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second side of the triangle: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third side of the triangle: ");
        double side3 = double.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle type: Equilateral.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("Triangle type: Isosceles.");
        }
        else
        {
            Console.WriteLine("Triangle type: Scalene.");
        }
    }
}