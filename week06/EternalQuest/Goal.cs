abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        return $"[ ] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
    public string GetName()
    {
        return _shortName;
    }
    public int GetPoints()
    {
        return _points;
    }
}