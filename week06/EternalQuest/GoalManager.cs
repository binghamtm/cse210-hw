using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        string userSelection = "";

        while (userSelection != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            userSelection = Console.ReadLine();
            if (userSelection == "1")
            {
                CreateGoal();
            }
            else if (userSelection == "2")
            {
                DisplayGoalsInfo();
            }
            else if (userSelection == "3")
            {
                Console.WriteLine("Please enter a filename ending in '.txt': ");
                string fileName = Console.ReadLine();
                SaveGoals(fileName);
            }
            else if (userSelection == "4")
            {
                Console.WriteLine("Please enter a filename to load from: ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
            }
            else if (userSelection == "5")
            {
                RecordEvent();
            }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your points: {_score}");
    }
    public void DisplayGoalsInfo()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: Checklist Goal");
        string goalSelection = Console.ReadLine();

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        Console.Write("Write a description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points is this worth? ");
        string points = Console.ReadLine();


        if (goalSelection == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalSelection == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalSelection == "3")
        {
            Console.Write("How many times would you like to complete this activity");
            string targetString = Console.ReadLine();
            int target = int.Parse(targetString);

            Console.Write($"How many points do you get upon completing this {target} time(s)");
            string bonusString = Console.ReadLine();
            int bonus = int.Parse(bonusString);
            
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which Goal did you accomplish?");
        DisplayGoalsInfo();
        string goalSelection = Console.ReadLine();
        int goalSelectionInt = int.Parse(goalSelection);
        
        int goalSelectionIndex = goalSelectionInt - 1;

        _score += _goals[goalSelectionIndex].RecordEvent();
    }
    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        string score = lines[0];
        _score = int.Parse(score);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("~");
            string shortName = parts[1];
            string description = parts[2];
            string points = parts[3];

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(shortName, description, points);
                _goals.Add(goal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string target = parts[6];
                int targetInt = int.Parse(target);

                string bonus = parts[4];
                int bonusInt = int.Parse(bonus);

                string amountCompleted = parts[5];

                ChecklistGoal goal = new ChecklistGoal(shortName, description, points, targetInt, bonusInt);
                _goals.Add(goal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(shortName, description, points);
                _goals.Add(goal);
            }
            else
            {
                Console.WriteLine("Invalad Goal Type");
            }
        }
    }
}