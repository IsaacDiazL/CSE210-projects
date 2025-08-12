using System.Drawing;

class ChecklistGoal : EternalGoal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted < _target)
        {
            Console.WriteLine($"Congratulations! You've earned {_points} points");
        }
        else if (_amountCompleted == _target)
        {
            Console.WriteLine($"Good job!! Goal completed, you have earned a bonus of {_bonus} points");
            _points = 0;
            _points += _bonus;
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        if (_amountCompleted == _target)
        {
            return $"[X] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}