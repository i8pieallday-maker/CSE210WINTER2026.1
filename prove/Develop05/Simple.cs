class Simple : Goal
{

    public Simple(): base()
    {
        
    }
    public void SetPoints(int _points)
    {
        
    }
    public void UpdateInfo()
    {
        
    }

    public override void CreateGoal()
    {
        base.SetName();
        base.SetDescription();
        base.SetPoints();
    }
}