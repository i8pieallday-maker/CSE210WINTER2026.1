class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public double GetMinutes()
    {
        return _minutes;
    }
    public string GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date} Minutes: {_minutes} " +
        $"Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}