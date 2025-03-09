using System;

class Program
{
    static void Main(string[] args)
    {
        bool correctGuess = false;
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

       

        
        do
        {
             Console.Write("Enter a guess: ");
            string stringUserGuess = Console.ReadLine();
            int userGuess = int.Parse(stringUserGuess);
            if (magicNumber > userGuess)
            {
                Console.WriteLine("higher"); 
            }
            else if (magicNumber < userGuess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("correct!");
                correctGuess = true;
            }
        } while (correctGuess == false);
        
    }
}