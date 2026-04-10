using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("04 Apr 2026", 30, 3.0));
        activities.Add(new Cycling("30 Sep 2004", 60, 7.2));
        activities.Add(new Swimming("01 Sep 2004", 90, 11));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}