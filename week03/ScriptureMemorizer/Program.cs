using System;
//To exceed the requirements, when I hit enter, my program takes away 3 words every time, and keeps track of which words have already been taken away. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();
        string userInputLowercase = "";
        
        string book = "1 Nephi";
        int chapter = 1;
        int startVerse = 1;
        int endVerse = 2;
        string text = "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";
        int numberToHide = 3;

        Reference reference = new Reference(book, chapter, startVerse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        while (userInputLowercase != "quit")
        {
            Console.Write(reference.getDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();
            userInputLowercase = userInput.ToLower();
            scripture.HideWord(numberToHide);
            Console.Clear();
            if (scripture.IsCompletelyHidden() == true)
            {
                userInputLowercase = "quit";
            }
        }
    }
}