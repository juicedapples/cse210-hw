using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string input;

        do
        {
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Welcome to the Journal Progam!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            if (input == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("MM/dd/yyyy");

                Entry newEntry = new Entry(date, prompt, response);
                journal.AddEntry(newEntry);

                Console.WriteLine(newEntry.Display());
            }
            else if (input == "2")
            {
                journal.DisplayAll();
            }
            else if (input == "3")
            {
                Console.Write("What is the filename? ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                Console.WriteLine($"{loadFile}");
            }
            else if (input == "4")
            {
                Console.Write("What is the filename? ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (input != "5")
            {
                Console.WriteLine("Invalid choice. Please select 1-5.");
            }

        } while (input != "5");

        Console.WriteLine("Thank you for using the Journal! Bye!");
    }
}
