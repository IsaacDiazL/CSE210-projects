// Stores a list of journal entries
public class Journal
{
    // List to hold journal entries
    public List<Entry> _entries = new List<Entry>();
    // Method to add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    // Method to display all entries in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    // Method to save entries to a file
    public string SaveToFile(string file)
    {
        // Save entries to a file
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // Write each entry to the file
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} || {entry._promptText} || {entry._entryText}");
            }
        }
        return "";
    }
    // Method to load entries from a file
    public string LoadFromFile(string file)
    {
        // Load entries from a file
        // Check if the file exists
        if (File.Exists(file))
        {
            // remove existing entries
            _entries.Clear();
            // Read all lines from the file and create Entry objects
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split(" || ");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Entries loaded from {file}");
            Console.ResetColor();
        }
        // If the file does not exist, display an error message
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("File not found.");
            Console.ResetColor();
        }
        return "";
    }
}