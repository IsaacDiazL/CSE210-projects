public class Resume()
{
    public string _personName = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine(_personName);
        Console.WriteLine("Jobs:");

        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }
}