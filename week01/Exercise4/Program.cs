using System;

class Program
{
    static void Main(string[] args)
    {
        string userNumber;
        float number;
        float sum = 0;
        float len;
        float average;
        float max;
        List<float> numberList = new List<float>();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        do
        {
            Console.Write("gimme a number, enter 0 to tell me your list is complete: ");
            userNumber = Console.ReadLine();
            number = float.Parse(userNumber);
            if (number != 0)
            {
                numberList.Add(number);
            }
        } while (number != 0);

        foreach (float num in numberList)
        {
            sum = sum + num;
        }
        Console.WriteLine($"Sum: {sum}");

        len = numberList.Count;
        average = sum/len;

        Console.WriteLine($"average: {average}");

        max = numberList.Max();

        Console.WriteLine($"Largest Number: {max}");

        

    }
}