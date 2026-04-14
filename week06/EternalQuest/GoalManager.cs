using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");

            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select: ");
            string input = Console.ReadLine();

            Console.Clear();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
                case 6: return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        if (!int.TryParse(Console.ReadLine(), out int type))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine() ?? "";

        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine() ?? "";

        Console.Write("What is the amount of points associated with this goal? ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        if (type == 1)
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (type == 2)
            _goals.Add(new EternalGoal(name, desc, points));

        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine() ?? "0");

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("Goal created!");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record:\n");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        Console.Write("\nEnter the number of the goal: ");

        if (!int.TryParse(Console.ReadLine(), out int index))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        if (index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal goal = _goals[index - 1];
        goal.RecordEvent();

        int earned = goal.GetPoints();

        if (goal is ChecklistGoal c && c.GetAmountCompleted() == c.GetTarget())
        {
            earned += c.GetBonus();
        }

        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }
    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine() ?? "";

        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine($"Points:{_score}");

            foreach (Goal g in _goals)
                writer.WriteLine(g.GetStringRepresentation());
        }

        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine() ?? "";

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);

        _goals.Clear();

        foreach (string line in lines)
        {
            if (line.StartsWith("Points:"))
            {
                _score = int.Parse(line.Split(":")[1]);
            }
            else
            {
                string[] parts = line.Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(",");

                if (type == "SimpleGoal")
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));

                else if (type == "EternalGoal")
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));

                else if (type == "ChecklistGoal")
                    _goals.Add(new ChecklistGoal(
                        data[0], data[1], int.Parse(data[2]),
                        int.Parse(data[4]), int.Parse(data[3]),
                        int.Parse(data[5])));
            }
        }

        Console.WriteLine("Goals loaded!");
    }
}