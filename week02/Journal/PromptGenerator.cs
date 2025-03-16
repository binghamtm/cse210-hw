using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
    "What is one challenge I faced today, and how did I handle it?",
    "What is something I’m grateful for today that I may have overlooked yesterday?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomPromptNumber = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomPromptNumber];
        return randomPrompt;
    }
}