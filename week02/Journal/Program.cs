using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
using System.IO;

// Exceeding requirements:
// 1. Added color text to the console output for better visibility.
// 2. displayed an error message if the file does not exist when loading entries.
// 3. added a txt file extension when saving and loading entries by default.
class Program
{
    static void Main(string[] args)
    {
        // Display a menu
        Console.WriteLine("Welcome to the Journal Program!");
        // Create a new Journal instance
        Journal journal = new Journal();
        // Initialize menu option
        int menuOption = 0;
        // Loop until the user chooses to exit
        while (menuOption != 5)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n1. Add a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to file");
            Console.WriteLine("4. Load entries from file");
            Console.WriteLine("5. Exit");
            Console.Write("Please select an option (1-5): ");
            Console.ResetColor();
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
                // Set the date and time for the entry
                response._date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                // Set the prompt text for the entry
                response._promptText = question;
                // Create a new Journal instance and add the entry

                journal.AddEntry(response);

            }
            if (menuOption == 2)
            {
                // Display all entries in the journal
                Console.WriteLine("Displaying all journal entries:");
                Console.ForegroundColor = ConsoleColor.Magenta;
                journal.DisplayAll();
                Console.ResetColor();
            }
            if (menuOption == 3)
            {
                // Save entries to a file
                Console.Write("Enter the filename to save entries: ");
                string fileName = Console.ReadLine();
                // Ensure the file name is a txt file
                journal.SaveToFile(fileName + ".txt");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Entries saved to {fileName}");
                Console.ResetColor();
            }
            if (menuOption == 4)
            {
                // Load entries from a file
                Console.Write("Enter the filename to load entries: ");
                string fileName = Console.ReadLine();
                // Ensure the file name is a txt file
                journal.LoadFromFile(fileName + ".txt");
            }
        }
    }
}