using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name}.\n");
        Console.WriteLine(_description + "\n");

        _duration = ErrorHandler.GetIntInput("How long, in seconds, would you like for your session? ");

        Console.WriteLine("\nGet ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\", "|"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[i]);
            Thread.Sleep(150);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
                i = 0;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}