using System;

class TicketPriceCAlculator
{
    static void Main()
    {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 12 || age >=65)
        Console.WriteLine("Ticket price: GHc7");
        else
        Console.WriteLine("Ticket price: GHc10");
    }
}