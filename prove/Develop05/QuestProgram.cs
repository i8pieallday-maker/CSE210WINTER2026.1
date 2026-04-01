using System;

class Program
{
    static void Main(string[] args)
    {
        Simple mySimpleGoal = new Simple();
        mySimpleGoal.CreateGoal();
        
        Console.WriteLine(mySimpleGoal.GetConsoleString());
        Console.Write("Set goal name: ");
        goal.SetName(Console.ReadLine());
    }

}