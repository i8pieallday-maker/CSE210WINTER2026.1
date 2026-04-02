class Checklist : Goal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public Checklist(string goalType) : base(goalType)
    {
        _numberOfCompletions = 0;
        _maxGoals = 0;
        _bonusPoints = 0;
    }

    // public int CheckListGoal()
    // {
        
    // }
    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetPoints();

        ObtainMaxGoal();
        ObtainBonusPoints();

        _numberOfCompletions = 0;
    }
    public override int RecordEvent()
    {
        if (_numberOfCompletions < _maxGoals)
        {
            _numberOfCompletions++;

            int pointsEarned = GetPoints();

            if (_numberOfCompletions == _maxGoals)
            {
                Console.WriteLine("You did it! Bonus points awarded.");
                pointsEarned += _bonusPoints;
                SetStatus(true);
            }

            return pointsEarned;
        }

        return 0;
    }
    public override string GetConsoleString()
    {
        return $"{base.GetConsoleString()}, Number completed: {_numberOfCompletions}, Max goals: {_maxGoals} ";
    }
    public override string GetFileSystemString()
    {
        return base.GetFileSystemString();
    }
    private void ObtainMaxGoal()
    {
        Console.WriteLine("How many times to do it?: ");
        _maxGoals = int.Parse(Console.ReadLine());
    }
    private void ObtainBonusPoints()
    {
        Console.WriteLine("How many bonus points on completion?: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

}