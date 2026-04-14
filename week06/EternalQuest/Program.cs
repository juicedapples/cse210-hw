using System;

class Program
{
    static void Main(string[] args)
    {
        //creative add on error handler
        ErrorHandler.SafeExecute(() =>
        {
            GoalManager manager = new GoalManager();
            manager.Start();
        });
    }
}