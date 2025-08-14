using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        RunningActivity running = new RunningActivity(30, 7000);
        CyclingActivity cycling = new CyclingActivity(15, 8500);
        SwimmingActivity swimming = new SwimmingActivity(35, 10);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        Console.Clear();
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}