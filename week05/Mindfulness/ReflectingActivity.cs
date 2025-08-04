class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();
    private List<string> _usedQuestions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity guides you to reflect on meaningful experiences, helping you gain insights and learn from past moments. Reflection can increase self-awareness and promote personal growth.";
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
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
        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have somehting in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following quesitons as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        _usedQuestions.Clear();
        while (DateTime.Now < endTime && _usedQuestions.Count < _questions.Count)
        {
            DisplayQuestions();
        }
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        List<string> availableQuestions = _questions.Except(_usedQuestions).ToList();
        if (availableQuestions.Count == 0)
            {
                return null;
            }

        int index = random.Next(0, availableQuestions.Count);
        string selectedQuestion = availableQuestions[index];
        _usedQuestions.Add(selectedQuestion);
        return selectedQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"----{GetRandomPrompt()}----");
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        if (question != null)
        {
            Console.Write(question);
            ShowSpinner(15);
            Console.WriteLine();
        }
    }
}