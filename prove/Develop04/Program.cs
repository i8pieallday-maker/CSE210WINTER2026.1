using System;

class Program1
{
    static void Main(string[] args)
    {
        BaseActivity baseActivity = new BaseActivity("Breathing", "This activity will help you breathe more better.");

        baseActivity.Greeting();
        baseActivity.Description();
    }
}