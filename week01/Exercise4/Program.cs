using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int answer = -1;
        int total = 0;
        int largest = 0;
        while (answer != 0)
        {
            Console.Write("Enter number: ");
            string j = Console.ReadLine();
            answer = int.Parse(j);
            if (answer != 0)
            {
                numbers.Add(answer);
            }
        }
        foreach (int j in numbers)
        {
            if (largest < j)
            {
                largest = j;
            }
            total += j;
        }
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

            
    }
}