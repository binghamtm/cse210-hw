using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        fraction = new Fraction(7);
        Console.WriteLine(fraction.GetFractionString());
        fraction = new Fraction(7, 11);
        Console.WriteLine(fraction.GetFractionString());

    }
}