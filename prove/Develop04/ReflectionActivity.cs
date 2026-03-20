
class ReflectionActivity : BaseActivity
{

    private string[] prompts =
    {
        "hello this is a prompt be inspired",
        "the sun is very shiny. How does that make you feel?",
        "Win or lose, all that matters is how many pages you can get added to the rulebook. What technicalities will you exploit today?",
        "You're a star! What giant ball of plasma are you?",
        "Frogs.",
        "I don't got anything else.",
        "FEEL INSPIRED."
    };

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }

    public ReflectionActivity(string name, string description) : base(name, description)
    {
    }

    private void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i+ " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void RunActivity()
    {
        Console.WriteLine();
        Greeting();
        //get number of seconds
        Console.WriteLine($"Ready in: ");
        ShowCountDown(5);
        Console.WriteLine(GetRandomPrompt());
        //get ready -> run countdown
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            int timeRemaining = (int)(endTime - DateTime.Now).TotalSeconds;
            DisplaySpinner("Time remaining: ",  timeRemaining);
            Thread.Sleep(1000);
        }
        //while seconds exist etc. 
        //let em think
        //display ending
    } 
}
