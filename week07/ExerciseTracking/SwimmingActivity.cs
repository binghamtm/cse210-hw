public class SwimmingActivity : Activity
{
    private double _laps;
    public SwimmingActivity(double laps, string date, double length) : base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return (_laps * 50 / 1000 * 0.62);
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
    public override double GetSpeed()
    {
        return GetDistance() / _length;
    }
    public override string GetSummary()
    {
        return $"{_date} - Swimming ({_length} min) - Distance {GetDistance()} miles - Speed {GetSpeed()} mph - Pace {GetPace()} minutes per Mile";
    }
}