public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresentation()
    {
        return "";
    }
}