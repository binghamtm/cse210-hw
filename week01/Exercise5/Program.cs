using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            String userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);
            return number;
        }
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, your favorite number squared is {squaredNumber}");
        }
    }
}