using System;
using System.Data.Common;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalManager = new GoalManager();
        int choice = 0;
        while (choice != 6)
        {
            goalManager.Start();
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                goalManager.CreateGoal();
            }

            if (choice == 2)
            {
                goalManager.ListGoalNames();
            }
            if (choice == 3)
            {
                goalManager.SaveGoals();
            }
            if (choice == 4)
            {
                goalManager.LoadGoals();
            }
            if (choice == 5)
            {
                goalManager.RecordEvent();
            }
            if (choice > 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice, please try again...");
                Thread.Sleep(1500);
                Console.ResetColor();
                Console.Clear();
            }
        }

    }
}