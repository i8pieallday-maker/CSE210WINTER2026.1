abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _status;

    // public string DisplayGoal()
    // {
        
    // }
    public void SetGoalName()
    {
        
    }

    public string GetGoalName()
    {
        
    }
    public int SetPoints()
    {
        
    }
    public int GetPoints()
    {
        
    }
    abstract public int GetCompletedPoints();
    abstract public void UpdateInfo();
    public void SaveGoalsToFile()
    {
        
    }
    public void GetGoalsFromFile()
    {
        
    }
}
