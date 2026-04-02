using System;
using System.IO;

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
        //ObtainFileName("Enter filename to save: ");
      
        // check if file exists
        string filepath = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(filepath))
        {
            outputFile.WriteLine($"Score#{_totalScore}");
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetFileSystemString()}");
            }
        }
    }
    public void DisplayGoals()
    {
        int count = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{++count}: {goal.GetConsoleString()}");
        }
    }
    public string GetDisplayScore()
    {
        return $"Total score: {_totalScore}";
    }
    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you complete?: ");
        int index = int.Parse(Console.ReadLine());
        Goal goal = _goals[index - 1];
        _totalScore += goal.RecordEvent();
    }
    private void ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        _filename = Console.ReadLine();
    }
}