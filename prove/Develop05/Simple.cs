class Simple : Goal
{

    public Simple(string name, string description, int points, bool status, string goalType) : base(name, description, points, status, goalType)
    {
        
    }

    public Simple(string goalType): base(goalType)
    {
        
    }

    public override void CreateGoal()
    {
        base.SetName();
        base.SetDescription();
        base.SetPoints();
    }

    public override int RecordEvent()
    {
        SetStatus(true);
        return GetPoints();
    }
}