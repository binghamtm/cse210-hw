public class BicycleActivity : Activity
{
    private double _speed;
    public BicycleActivity(double speed, string date, double length) : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * _length / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} - Biking ({_length} min) - Distance {GetDistance()} miles - Speed {GetSpeed()} mph - Pace {GetPace()} minutes per Mile";
    }
    
}