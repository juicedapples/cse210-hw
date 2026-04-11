//creative add on catch all error handler
using System;

public static class ErrorHandler
{
    public static int GetIntInput(string prompt)
    {
        while (true)
        {
            try
            {
                Console.Write(prompt);
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    public static void Handle(Exception ex)
    {
        Console.WriteLine("\nAn unexpected error occurred.");
        Console.WriteLine(ex.Message);
    }
}