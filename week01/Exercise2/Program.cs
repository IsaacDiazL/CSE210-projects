using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string j = Console.ReadLine();
        int percentage = int.Parse(j);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        if (percentage >= 70)
        {
            Console.WriteLine($"Grade: {letter}");
            Console.WriteLine("Congratulations!! you passed the course");
        }
        else
        {
            Console.WriteLine($"Grade: {letter}");
            Console.WriteLine("required percentage not gather,but don't worry,  still strive and try again fro next time!");
        }
    }
}