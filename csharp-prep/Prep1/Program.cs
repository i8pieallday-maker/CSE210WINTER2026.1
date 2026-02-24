using System;

class Program
{
    public static void Main(string[] args)
    {
        //int x = 10; //x needs to be assigned at first
        string firstName;
        string lastName;

        Console.Write("What is your first name?: "); //needs semi colon
        firstName = Console.ReadLine();
        Console.Write("What is your last name?: ");
        lastName = Console.ReadLine();
        Console.WriteLine($"{lastName}. {firstName} {lastName}.");
    }
}