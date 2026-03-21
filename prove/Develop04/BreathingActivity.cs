
class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void RunActivity()
    {
        Console.WriteLine();
        Greeting();
        Duration();
        //get number of seconds
        Console.WriteLine($"Ready in: ");
        ShowCountDown(5, 700);
        //get ready -> run countdown
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in");
            ShowCountDown(5, 1000);

            Console.WriteLine("Breathe Out");
            ShowCountDown(6, 1000);
        }
        Console.WriteLine("\nGood job!\n");
    } 
}