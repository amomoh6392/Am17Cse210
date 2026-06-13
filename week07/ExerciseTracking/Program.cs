using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2026, 6, 1), 30, 5.0));
        activities.Add(new Cycling(new DateTime(2026, 6, 3), 45, 20.0));
        activities.Add(new Swimming(new DateTime(2026, 6, 5), 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}