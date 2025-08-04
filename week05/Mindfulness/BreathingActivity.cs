class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will guide you through a calming breathing exercise to promote relaxation and mindfulness";
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
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("\n");
        }
        DisplayEndingMessage();
    }
}