using System;

class Program
{
    static void Main(string[] args)
    {
        //creative add in error handler
        ErrorHandler.SafeExecute(() =>
        {
            GoalManager manager = new GoalManager();
            manager.Start();
        });
    }
}