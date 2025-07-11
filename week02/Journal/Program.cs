using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // Display a menu
        Console.WriteLine("Welcome to the Journal Program!");
        int menuOption = 0;
        while (menuOption != 5)
        {
            Console.WriteLine("1. Add a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option (1-5): ");
            string j = Console.ReadLine();
            menuOption = int.Parse(j);

            if (menuOption == 1)
            {
                // Create a new PromptGenerator instance and display a random prompt
                PromptGenerator generate = new PromptGenerator();
                string question = generate.GetRandomPrompt();
                Console.Write(question);
                // Create a new Entry instance and prompt the user for input 
                Entry response = new Entry();
                response._entryText = Console.ReadLine();
                response._date = DateTime.Now.ToString("yyyy-MM-dd");
                response._promptText = question;
                // Create a new Journal instance and add the entry
                Journal journal = new Journal();
                journal.AddEntry(response);

            }            
            if (menuOption == 2)
            {
                // Display all entries
                Journal journal = new Journal();
                journal.DisplayAll();
            }
           
        }
    }
}