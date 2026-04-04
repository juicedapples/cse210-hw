using System;

public class ErrorHandler
{
    // Create add on Handles and logs exceptions
    public static void HandleException(Exception ex)
    {
        Console.WriteLine("An unexpected error occurred: " + ex.Message);
        Console.WriteLine("Stack Trace: " + ex.StackTrace);
    }
}