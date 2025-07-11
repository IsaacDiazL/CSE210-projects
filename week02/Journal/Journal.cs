// Stores a list of journal entries
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        Console.WriteLine($"{entry} --- this the entry value ---");
        entry.Display();
    }
    public void DisplayAll()
    {

    }
    public string SaveToFile(string file)
    {
        return "";
    }
    public string LoadFromFile(string file)
    {
        return "";
    }
}