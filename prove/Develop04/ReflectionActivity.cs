
class ReflectionActivity : BaseActivity
{

    private string[] prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "the sun is very shiny. How does that make you feel?",
        "Win or lose, all that matters is how many pages you can get added to the rulebook. What technicalities will you exploit today?",
        "Frogs."
    };

    private string[] questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }

    public ReflectionActivity(string name, string description) : base(name, description)
    {
    }

    public void RunActivity()
    {
        Console.WriteLine();
        Greeting();
        Console.WriteLine();
        //get number of seconds
        //Console.WriteLine($"Ready in: ");
        //ShowCountDown(5, 300);
        //get ready -> run countdown
        int i = 0;
        Console.WriteLine(GetRandomPrompt());

        while (i < 7)
        {
            Console.WriteLine(questions[i]);
            DisplaySpinner(1);
            i += 1;
        }
            // int timeRemaining = (int)(endTime - DateTime.Now).TotalSeconds;
            // Console.Write($"\rTime remaining: {timeRemaining}");
        Console.WriteLine("\nGood job!\n");
    }
        //while seconds exist etc. 
        //let em think
        //display ending
} 
