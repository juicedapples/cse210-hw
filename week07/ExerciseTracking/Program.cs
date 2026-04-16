using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running("03 Nov 2022", 30, 4.8));
            activities.Add(new Cycling("03 Nov 2022", 45, 20.0));
            activities.Add(new Swimming("03 Nov 2022", 30, 20));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
