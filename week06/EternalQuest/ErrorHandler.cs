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
            Console.WriteLine("\nAn unexpected error occurred.");
            Console.WriteLine($"Details: {ex.Message}");
        }
    }
}