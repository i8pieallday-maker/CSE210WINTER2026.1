
class BaseActivity
{
    protected int _duration;
    protected string _name;
    protected string _description;
    protected DateTime _endTime;

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
        Console.WriteLine(_description);
    }

    public void Duration()
    {
        Console.Write("How long do you want your session to go for? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void Description()
    {
        Console.WriteLine(_description);
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    protected string GetRandomPrompt(List<string> prompts)
    {
        Random rand = new Random();

        if (prompts.Count == 0)
        {
            return "No more prompts :(";
        }
        
        int index = rand.Next(prompts.Count);
        string prompt = prompts[index];

        prompts.RemoveAt(index); //doesn't repeat the same prompts :)

        return prompt;
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }

    protected void ShowCountDown(int seconds, int speed)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i+ " ");
            Thread.Sleep(speed);
        }
        Console.WriteLine();
    }

    protected void ReflectTimer(int seconds)
    {
         for (int i = seconds; i > 0; i--)
        {
            Thread.Sleep(1000);
        }
    }
    
    public void DisplaySpinner(int seconds)
    {
        // DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(seconds);
        int width = 20;
        string leftAnimationString = "<'(((><";
        string rightAnimationString = "><)))'>";
        int sleepTime = 80;
        
        Console.CursorVisible = false;   
        for (int s = 0; s < seconds; s++)
        {
            for (int i = 0; i < width; i++)
            {
                string frame = new string(' ', i) + rightAnimationString;
                Console.Write("\r" + frame.PadRight(40));              
                Thread.Sleep(sleepTime);
            }
            for (int i = width; i > 0; i--)
            {
                string frame = "\r" + new string(' ', i) + leftAnimationString;
                Console.Write("\r" + frame.PadRight(40));              
                Thread.Sleep(sleepTime);
            }
        }
        Console.CursorVisible = true;
        Console.Write("\r" + new string(' ', width + 10) + "\r"); //clear line    }
    
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
