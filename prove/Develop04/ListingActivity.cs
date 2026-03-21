using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public void RunActivity()
    {
        Console.WriteLine();
        Greeting();
        Duration();
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine(prompt);

        Console.WriteLine("Start listing");
        StartTimer();
        
        List<string> list = new List<string>();

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            list.Add(Console.ReadLine());
        }
        
        Console.WriteLine("\nGood job!");
        Console.WriteLine("You listed " + list.Count + " items.");
    }

}