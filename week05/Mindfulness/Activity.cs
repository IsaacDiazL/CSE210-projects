class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public List<string> spinner = new List<string>();
    public Activity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times...";
        _duration = 30;
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} Activity\n");
        Thread.Sleep(2000);
        Console.WriteLine(_description + "\n");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner();
        Console.Clear();
    }
    public void ShowSpinner(int seconds = 5)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string spin = spinner[i];
            Console.Write(spin);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int countdown = 5)
    {
        for (int i = countdown; i > 0; i--)
        {
            Console.Write("\r{0:00}", i);
            System.Threading.Thread.Sleep(1000); // espera 1 segundo
        }
        Console.WriteLine();
    }
}