public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void GetSeconds()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string stringSeconds = Console.ReadLine();
        int seconds = int.Parse(stringSeconds);
        _duration = seconds;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }
    
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        List<int> countdown = new List<int>();
        while (seconds >= 0)
        {
            countdown.Add(seconds);
            seconds --;
        }
        foreach (int second in countdown)
        {
            Console.Write(second);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}