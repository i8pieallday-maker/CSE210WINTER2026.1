using System;

class Program1
{
    static void Main(string[] args)
    {
        BaseActivity baseActivity = new BaseActivity("Breathing", "This activity will help you breathe more better.");

        baseActivity.Greeting();
        baseActivity.Description();

        baseActivity.DisplaySpinner("Hey howdy", 5);

        ListingActivity listingActivity = new ListingActivity("Listing","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        listingActivity.RunActivity();
    }
}