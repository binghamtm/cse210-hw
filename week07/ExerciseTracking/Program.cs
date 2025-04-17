using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        RunningActivity runningActivity = new RunningActivity(10, "22 Oct 2025", 10);
        BicycleActivity bicycleActivity = new BicycleActivity(20, "23 Oct 2023", 20);
        SwimmingActivity swimmingActivity = new SwimmingActivity(10, "14 Aug 2323", 5);
        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(bicycleActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}