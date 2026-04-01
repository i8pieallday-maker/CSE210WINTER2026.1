abstract class Goal
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
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }
    public abstract void CreateGoal();

    public virtual string GetConsoleString()
    {
        return $"Goal Information: {_name}";
    }
    
}
