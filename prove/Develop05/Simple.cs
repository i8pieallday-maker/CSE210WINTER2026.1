class Simple : Goal
{

    public Simple(): base()
    {
        
    }

    public override void CreateGoal()
    {
        base.SetName();
        base.SetDescription();
        base.SetPoints();
    }
}