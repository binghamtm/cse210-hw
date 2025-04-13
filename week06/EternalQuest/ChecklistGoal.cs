public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override int RecordEvent()
    {
        int intPoints = int.Parse(_points);
        _amountCompleted ++;
        if (_amountCompleted == _target)
        {
            return intPoints + _bonus;
        }
        else 
        {
            return intPoints;
        }
        
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {_shortName} ({_description}) - Completed {_amountCompleted} out of {_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) - Completed {_amountCompleted} out of {_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal~{_shortName}~{_description}~{_points}~{_bonus}~{_amountCompleted}~{_target}";
    }
}