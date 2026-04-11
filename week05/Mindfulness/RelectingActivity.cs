using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _rand = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description =
        "This activity will help you reflect on times in your life when you have shown strength and resilience.";

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:");
        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nPress enter when ready...");
        Console.ReadLine();

        Console.WriteLine("\nYou may begin in:");
        ShowCountDown(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[_rand.Next(_questions.Count)];
            Console.WriteLine("\n> " + question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}