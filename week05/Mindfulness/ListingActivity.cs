public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();

    public ListingActivity()
    {
        _name = "Listening Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetSeconds();

        GetRandomPrompt();
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_responses.Count} responses");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int number = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[number - 1]);
    }

    public void GetListFromUser()
    {
        string response = Console.ReadLine();
        _responses.Add(response);
    }
}