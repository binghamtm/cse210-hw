using System;
public class Circle : Shape
{
    private double _radious;
    public Circle(string color, double radious) : base(color)
    {
        _radious = radious;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radious, 2);
    }
}