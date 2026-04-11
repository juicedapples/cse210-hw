using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _items;
    private Random _rand = new Random();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description =
        "This activity will help you reflect on the good things in your life by listing as many things as you can.";

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _items = new List<string>();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can:");
        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nYou may begin in:");
        ShowCountDown(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        _items.Clear();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                _items.Add(input);
                Console.WriteLine("-");
            }
        }

        Console.WriteLine($"\nYou listed {_items.Count} items.");

        DisplayEndingMessage();
    }
}