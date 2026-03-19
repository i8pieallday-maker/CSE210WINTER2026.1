
class BaseActivity
{
    private int _duration;
    private string _name;
    private string _description;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void Greeting()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
    }

    public void Description()
    {
        Console.WriteLine(_description);
    }
}

// static void ShowCountdown(int seconds)
// {
//     for (int i = seconds; i > 0; i--)
//     {
//         Console.Write(i);
//         Thread.Sleep(1000);
//     }
//     Console.WriteLine();
//}
