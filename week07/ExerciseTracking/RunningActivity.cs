class RunningActivity : Activity
{
    private int _meters;
    public RunningActivity(int minutes, int meters) : base(minutes)
    {
        _meters = meters;
        _activityName = "Running";

    }
    public override float Distance()
    {
        float distance = _meters / 1000f;
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