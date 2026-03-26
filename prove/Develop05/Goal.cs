class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;

    public Goal()
    {
        _name = "";
        _description = "";
        _status = false;
        _points = 0;
        _goalType = "";
    }
    public void SetName()
    {
        Console.Write("Set goal name: ");
        _name = Console.ReadLine();
    }

    public virtual string GetConsoleString()
    {
        return $"Goal Information: {_name}";
    }
    // public string GetGoalName()
    // {
        
    // }
    // public int SetPoints()
    // {
        
    // }
    // public int GetPoints()
    // {
        
    // }
    // abstract public int GetCompletedPoints();
    // abstract public void UpdateInfo();
    // public void SaveGoalsToFile()
    // {
        
    // }
    // public void GetGoalsFromFile()
    // {
        
    // }
}
