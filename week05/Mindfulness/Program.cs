using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int userSelection = 0;

        while (userSelection != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t 1. Start breathing activity");
            Console.WriteLine("\t 2. Start reflecting activity");
            Console.WriteLine("\t 3. Start listing activity");
            Console.WriteLine("\t 4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userSelectionString = Console.ReadLine();
            userSelection = int.Parse(userSelectionString);

            if (userSelection == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userSelection == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userSelection == 3)
            {
                ListingActivity listeningActivity = new ListingActivity();
                listeningActivity.Run();
            }
        }

        
    }
}