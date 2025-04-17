public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(double distance, string date, double length) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    public override double GetPace()
    {
        return _length / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} - Running ({_length} min) - Distance {GetDistance()} miles - Speed {GetSpeed()} mph - Pace {GetPace()} minutes per Mile";
    }
    
}