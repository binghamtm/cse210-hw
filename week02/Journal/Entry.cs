public class Entry
{
    public Entry()
    {
        
    }
    
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _gratefulForText;
    public string _happyLevel;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"Something I am grateful for: {_gratefulForText}");
        Console.WriteLine($"How happy was I on a scale of 1-10: {_happyLevel}");
    }
}