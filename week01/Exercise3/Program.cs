using System;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Random j = new Random();
        int magic = j.Next(1, 100);
        Console.Write("What is your guess? ");
        string k = Console.ReadLine();
        int guess = int.Parse(k);

        while (magic != guess)
        {
            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            k = Console.ReadLine();
            guess = int.Parse(k);
        }
        if (magic == guess)
        {
            Console.WriteLine("You guessed it!");
        }
        
    }
}