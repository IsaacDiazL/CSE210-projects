using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(userName, squareNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string j = Console.ReadLine();
            int number = int.Parse(j);
            return number;
        }
        static int SquareNumber(int userNumber)
        {
            int result = userNumber * userNumber;
            return result;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
    }
}