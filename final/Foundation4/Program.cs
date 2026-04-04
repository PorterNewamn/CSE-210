using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();

        Running r1 = new Running("Firday Apirl 3, 2026", 120.35, 26);
        activity.Add(r1);

        Swimming s1 = new Swimming("Thursday Apirl 2, 2026", 3282.30, 10203.24);
        activity.Add(s1);

        Cycling c1 = new Cycling("Wednesday Apirl 1, 2026", 4560.32, 26.6);
        activity.Add(c1);

        Console.Clear();
        foreach (Activity a in activity)
        {
            a.Calculate();
            a.GetSummery();
            Console.WriteLine("");
        }

        Console.WriteLine("");

        
    }
}