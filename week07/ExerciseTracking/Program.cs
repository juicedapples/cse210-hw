using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running("03 Nov 2022", 30, 3.0));
            activities.Add(new Cycling("03 Nov 2022", 30, 4.8));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }

        // creative add in error handler 
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
