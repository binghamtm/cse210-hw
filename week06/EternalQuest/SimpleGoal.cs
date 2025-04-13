public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }
    public override int RecordEvent()
    {
        _isComplete = true;
        int intPoints = int.Parse(_points);
        return intPoints;

    }
    public override bool IsComplete()
    {
        if (_isComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal~{_shortName}~{_description}~{_points}~{_isComplete}";
    }

}