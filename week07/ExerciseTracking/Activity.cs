using System.Security.Cryptography;

abstract class Activity
{
    protected int _minutes = 0;
    private int _day;
    private int _month;
    private int _year;
    protected string _activityName = "Activity";
    public Activity(int minutes)
    {
        _minutes = minutes;
        DateTime currentTime = DateTime.Now;
        _day = currentTime.Day;
        _month = currentTime.Month;
        _year = currentTime.Year;
    }
    public abstract float Distance();
    public abstract float Speed();
    public abstract float Pace();
    public virtual string GetSummary()
    {
        return $"{_day} {_month} {_year} {_activityName} ({_minutes} min) - Distance {Distance()} Km, Speed {Speed()} kph, Pace: {Pace()} min per Km";
    }
    
}