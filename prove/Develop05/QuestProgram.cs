using System;

class Program
{
    static void Main(string[] args)
    {
        // Goal myGoal = new Goal();
        // myGoal.SetName();
        // myGoal.SetDescription();
        // myGoal.SetPoints();
        // Console.WriteLine(myGoal.GetConsoleString());
        Simple mySimpleGoal = new Simple();
        mySimpleGoal.CreateGoal();
        Console.WriteLine(mySimpleGoal.GetConsoleString());
    }
}