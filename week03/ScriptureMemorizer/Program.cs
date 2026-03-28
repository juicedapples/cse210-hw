using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Reference refObj = new Reference("Proverbs", 3, 5, 6);

            Scripture verse = new Scripture(refObj,
                "Trust in the Lord with all thine heart and lean not unto thine own understanding");

            while (true)
            {
                Console.WriteLine(verse.GetDisplayText());

                if (verse.IsCompletelyHidden())
                {
                    Console.WriteLine("\nEverything is hidden. Goodbye!");
                    break;
                }

                Console.WriteLine("\nPress Enter to continue or type 'quit' to stop:");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                    break;

                verse.HideRandomWords(3);

                Console.Clear();
            }
        }
        //added catch all error messages
        catch (Exception ex)
        {
            Console.WriteLine("\nAn unexpected error occurred:");
            Console.WriteLine(ex.Message);
            Console.WriteLine("The program will now exit.");
        }
    }
}