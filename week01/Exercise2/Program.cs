using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade;
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("please input your grade percentage: ");
        string stringGrade = Console.ReadLine();
        float grade = int.Parse(stringGrade);

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you pass!");
        }
        else
        {
            Console.WriteLine("Sorry bub, you're gonna have to redo this course");
        }
    }
}