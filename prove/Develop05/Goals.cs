using System;

public class Goals
{
    private List<Goal> _goals;
    private string _filename;
    private int _totalScore;

    public Goals()
    {
        _goals = new List<Goal>();
        _filename = "";
        _totalScore = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals()
    {
        
    }
    public void SaveGoals()
    {
        
    }
    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetConsoleString());
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Total score: {_totalScore}");
    }
    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you complete?: ");
        int index = int.Parse(Console.ReadLine());
        Goal goal = _goals[index];
        goal.SetStatus(true);

        _totalScore += goal.GetPoints();
    }
    private void ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        _filename = Console.ReadLine();
    }
}