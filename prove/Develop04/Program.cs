using System;

class Program1
{

    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Mindfulness!");
        Console.WriteLine("Menu Options: \n1. Breathing Activity \n2. Listing Activity \n3. Reflection Activity \n4. Quit");


        int choice = int.Parse(Console.ReadLine());
        
        while(choice != 4)
        {
            Console.Clear();
            
            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you breathe more better.");
                breathing.RunActivity();
                //breathingActivity.DisplaySpinner("Hey howdy", 5);
            }

            else if (choice == 2)
            {
                ListingActivity listing = new ListingActivity("Listing","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                listing.RunActivity();
            }

            else if (choice == 3)
            {
                ReflectionActivity reflection = new ReflectionActivity("Reflection", "Consider the Following!");
                reflection.RunActivity();
            }

            Console.WriteLine("Menu Options: \n1. Breathing Activity \n2. Listing Activity \n3. Reflection Activity \n4. Quit");
            choice = int.Parse(Console.ReadLine());
        

        }

    }
}