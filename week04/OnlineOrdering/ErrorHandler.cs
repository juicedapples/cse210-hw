using System;
// Creative add on Handle errors
namespace ProductOrderSystem
{
    public static class ErrorHandling
    {
        public static void LogException(Exception ex)
        {
            Console.WriteLine("ERROR OCCURRED: " + ex.Message);
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }

        public static void DisplayGenericError()
        {
            Console.WriteLine("Oops! Something went wrong. Please try again later.");
        }
    }
}