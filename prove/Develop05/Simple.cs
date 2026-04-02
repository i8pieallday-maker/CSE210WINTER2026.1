class Simple : Goal
{

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
        return 0;
    }
}