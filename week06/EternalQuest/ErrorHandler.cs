// Creative add on Error handler class
using System;

public static class ErrorHandler
{
    public static void SafeExecute(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            Handle(ex);
        }
    }

    private static void Handle(Exception ex)
    {
        Console.WriteLine("\nAn unexpected error occurred.");
        Console.WriteLine($"Details: {ex.Message}");
        Console.WriteLine("The program will continue safely.\n");

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}