class ListingActivity : Activity
{
    protected int count;
    protected List<string> _prompts = new List<string>();
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session?: ");
        string number = Console.ReadLine();
        _duration = int.Parse(number);
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner();
        GetList();
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        Console.WriteLine($"----{_prompts[index]}----");
    }
    //method to get list from user
    public List<string> GetList()
    {
        List<string> list = new List<string>();
        count = 10;
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(count);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            list.Add(response);
        }
        Console.WriteLine($"You listed {list.Count} items.");
        list.Clear();
        return list;
    }
}