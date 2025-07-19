using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the Scripture, Word, and Reference classes
        string paragraph = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, paragraph);
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.ReadLine();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input != null && input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ended.");
                break;
            }
        }
    }
}