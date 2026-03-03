using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
     public static void passByValue(out int a)
    {
        a = 0;
    }

     public static void passByRef(out int g)
    {
        g = 1;
    }

    public static void passByOut(out int y)
    {
        y = 2;
    }
    public static void Main(string[] args)
    {
       int x = 20;
       Console.WriteLine($"in the main 1: {x}");

       passByValue(out x);
       Console.WriteLine($"in the main2: {x}");
       passByRef(out x);
       Console.WriteLine($"in the main 3L {x}");

       int z;
       passByOut(out z);
       Console.WriteLine(z);
        
    }
}

 /*
 
List<int> numbers = new List<int>();
        int input = -1;
        
        int total = 0;
        double average = 0;
        int bigNumber = 0;
        Console.WriteLine("Enter a list of numbers, 0 is illegal though\n");
        while (input != 0)
        {
            Console.Write($"Enter number: ");
            string response = Console.ReadLine();

            if (int.TryParse(response, out input))
            {
                numbers.Add(input);
            }
            else
            {
                Console.WriteLine("no try an actual number");
            }

            foreach (int n in numbers)
            {
                total += n;
            }
            average = (double)total / numbers.Count;
            bigNumber = numbers.Max();
        }

        Console.WriteLine($"Sum = {total}");
        Console.WriteLine($"average = {average}");
        Console.WriteLine("largest number = " + bigNumber);



 List<int> numbers = new List<int>();
        int input = -1;
        
        int total = 0;
        double average = 0;
        int bigNumber = 0;
        Console.WriteLine("Enter a list of numbers, 0 is illegal though\n");
        while (input != 0)
        {
            Console.Write($"Enter number: ");
            string response = Console.ReadLine();

            if (int.TryParse(response, out input))
            {
                numbers.Add(input);
            }
            else
            {
                Console.WriteLine("no try an actual number");
            }

            foreach (int n in numbers)
            {
                total += n;
            }
            average = (double)total / numbers.Count;
            bigNumber = numbers.Max();
        }

        Console.WriteLine($"Sum = {total}");
        Console.WriteLine($"average = {average}");
        Console.WriteLine("largest number = " + bigNumber);

        int response = -1;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        while (response != number)
        {
            
            Console.Write($"What's the number?");
            response = int.Parse(Console.ReadLine());
            if (response > number)
            {
                Console.WriteLine("Like icarus, you have flown too high");
            }
            else if (response < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("yay good job!!!!");
            }


        /*Console.WriteLine("helluuu");
        int age;

        Console.Write("please put in age: ");
        string response = Console.ReadLine();
        age = int.Parse(response);
        Console.WriteLine($"Your age is: {age}.");
        int x = 20;
        double z = 12.23;

        if (age <= 100 && age >= 0 && x <= 30 || z < 6)
        {
            Console.WriteLine("ur cool");
        }
        else if (age <= 150)
        {
            Console.WriteLine("woaaaah you're EXTRA cool");
        }
        else
        {
            Console.WriteLine("are you perchance an old testament poet");
        }

        //int x = 10; //x needs to be assigned at first
       string firstName;
        string lastName;


        Console.Write("dsafs dWhat is your first name?: "); //needs semi colon
        firstName = Console.ReadLine();
        Console.Write("What is your last name?: ");
        lastName = Console.ReadLine();
        Console.WriteLine($"{lastName}. {firstName} {lastName}.");*/

        /*for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        } //i initially = 0, then until i is no longer less than 10 it will add 1 and repeat. 

        int y = 10;
        int z = ++y;
        Console.WriteLine(y);
        Console.WriteLine(z);

        for(int i  = 100000; i >= -100000; i -= 10000)
        {
            Console.WriteLine(i);
        } //curly braces not technically needed for 1 line, but use for it anyways. 
        bool done = true;
        do
        {
            Console.Write("whats yer age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 125)
            {
                done = true;
                Console.WriteLine("thanks");
            }
            else
            {
                done = false;
                Console.WriteLine("i need an actual age porfa");
            }
        } while(! done);

        List<int> myData = new List<int>();
        myData.Add(10);
        myData.Add(11);
        myData.Add(12);
        myData.Add(13);
        myData.Add(14);
        myData.Add(15);
        myData.Add(16);

        Console.WriteLine(myData.Count);
        
        foreach(int i in myData)
        {
            Console.WriteLine(i);
        }*/
        class BobsYourUncle
    {
        public static void Greeting()
        {
            Console.WriteLine("hello bob");
        }

        //public static int AddNumbers(int n1, int n2)
            // {
            //     Console.WriteLine("bob");

            // }




}

//number.ToString(variable) - changes variable to a string

/*int x = 10;
int y = x++;
int z
Random randomGenerator = new Random();

*/

