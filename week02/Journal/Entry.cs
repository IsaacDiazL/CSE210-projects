// Represents a single journal entry
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
     public void Display()
    {
        // Display the entry in a formatted way using "||" as a separator

        Console.WriteLine($"{_date} || {_promptText} || {_entryText}");
    }
}