abstract public class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    private string _goalType;

    public Goal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _goalType = goalType;
    }
    public Goal(string goalType)
    {
        _name = "";
        _description = "";
        _status = false;
        _points = 0;
        _goalType = goalType;
    }
    public void SetName()
    {
        Console.WriteLine("Please enter goal name: ");
        _name = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.WriteLine("Please enter goal decription: ");
        _description = Console.ReadLine();
    }

    public void SetPoints()
    {
        Console.WriteLine("Please enter points goal is worth: ");
        _points = int.Parse(Console.ReadLine());
    }

    public int GetPoints()
    {
        return _points;
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
        if (_status)
        { 
            return $"[X] {_name}: {_description}, {_points}";
        }
        else
        {
            return $"[ ] {_name}: {_description}, {_points}";
        }
    }
    
    public virtual string GetFileSystemString()
    {
        return $"{_goalType}#{_name}#{_description}#{_points}#{_status}";
    }
    
    public abstract int RecordEvent();
}
