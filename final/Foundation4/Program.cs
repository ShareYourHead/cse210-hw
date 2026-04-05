using System;
using Foundation4;

class Program
{
    static void Main(string[] args)
    {
        //make activities
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("4/5/26",22,3.0));
        activities.Add(new Cycling("4/6/26",30,15.9));
        activities.Add(new Swimming("4/7/26",13,15));

        //print stuff
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}