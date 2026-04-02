class Eternal : Goal
{
    private int _numberOfCompletions;

    public Eternal(string goalType, int completions) : base(goalType)
    {
        _numberOfCompletions = 0;
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }
    public override int RecordEvent()
    {
        return 0;
    }
    public override string GetConsoleString()
    {
        return base.GetConsoleString();
    }
    public override string GetFileSystemString()
    {
        return base.GetFileSystemString();
    }
}