class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(int minutes, int laps) : base(minutes)
    {
        _laps = laps;
        _activityName = "Swimming";
    }
    public override float Distance()
    {
        float distance = _laps * 50 / 1000f;
        return distance;
    }
    public override float Pace()
    {
        float pace = _minutes / Distance();
        return (float)Math.Round(pace, 2);
    }
    public override float Speed()
    {
        float speed = Distance() / _minutes * 60;

        return (float)Math.Round(speed, 2);
    }
}