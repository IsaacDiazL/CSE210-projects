using System.Data;

class GoalManager
{
    List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        DisplayPlayerInfo();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu by number: ");
    }
    public void DisplayPlayerInfo()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nYou have {_score} points.");
        Console.ResetColor();
        
    }
    public void ListGoalNames()
    {
        int i = 1;
        Console.WriteLine("\nThe goals are:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
        Console.ResetColor();
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("1. Simple Goal");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("2. Eternal Goal");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("3. Checklist Goal");
        Console.ResetColor();
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine();
        if (_goals.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No goals available. Please create some goals first.");
            Thread.Sleep(2000);
            Console.ResetColor();
            return;
        }
        int i = 1;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
        Console.ResetColor();
        Console.Write("Which goal did you accomplish?: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice <= _goals.Count)
        {
            var selectedGoal = _goals[choice - 1];
            if (selectedGoal.IsComplete())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You have already completed this goal...");
                Thread.Sleep(1500);
                Console.ResetColor();
            }
            else
            {
                selectedGoal.RecordEvent();
                _score += selectedGoal.GetPoints();
            }
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }

    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the Goal File (Do not add extension '.txt'): ");
        string j = Console.ReadLine();
        string filename = j + ".txt";
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Goal File added as '{filename}'");
        Console.ResetColor();
        Console.Write("press enter to continue...");
        Console.ReadLine();

    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the Goal File (Do not include '.txt'?: ");
        string j = Console.ReadLine();
        string filename = j + ".txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalName = lines[i].Split(":");
            string[] parts = lines[i].Split(",");
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            if (goalName[0] == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }
            if (goalName[0] == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }
            if (goalName[0] == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[3]);
                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklist);
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("File succesfuly opened...");
        Console.ResetColor();
        Console.Write("press enter to continue...");
        Console.ReadLine();
    }
}