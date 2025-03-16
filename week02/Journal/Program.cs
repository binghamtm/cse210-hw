// to exceed the requirements, I added a prompt to write down something you were grateful for that day, as well as a scale of 1-10 how happy you were that day. 

using System;

class Program
{
    static void Main(string[] args)
    {
        int userPref = 0;
        
        Console.WriteLine("Welcome to your Journal!");
        
        DateTime theCurrentTime = DateTime.Now;
        
        Journal journal = new Journal();
        

        do
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userPrefstring = Console.ReadLine();
            userPref = int.Parse(userPrefstring);

        if (userPref == 1)
        {
            Entry entry = new Entry();
            entry._date = theCurrentTime.ToShortDateString();
            PromptGenerator newPrompt = new PromptGenerator();
            entry._promptText = newPrompt.GetRandomPrompt();
            Console.WriteLine(entry._promptText);
            entry._entryText = Console.ReadLine();
            Console.WriteLine("What is one thing you were grateful for today? ");
            entry._gratefulForText = Console.ReadLine();
            Console.Write("How happy were you on a scale of 1-10? ");
            entry._happyLevel = Console.ReadLine();
            journal.AddEntry(entry);
        }
        else if (userPref == 2)
        {
            journal.DisplayAll();
        }
        else if (userPref == 3)
        {
            Console.Write("Enter the file name you want to load in: ");
            string fileName = Console.ReadLine();
            journal.LoadFromFile(fileName);
        }
        else if (userPref == 4)
        {
            Console.Write("Enter a new filename to save: ");
            string fileName = Console.ReadLine();
            journal.SaveToFile(fileName);
        }
        } while (userPref != 5);

        Console.WriteLine("Have a great day!") ;  
    
    }

}