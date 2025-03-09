using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("Please input your first name: ");
        String firstName = Console.ReadLine();

        Console.Write("Please input your last name: ");
        String lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}