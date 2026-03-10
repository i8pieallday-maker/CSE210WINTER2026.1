using System;

class Program1
{

    static void Main(string[] args)
    {
        Fraction f = new Fraction(3,4);
        Console.WriteLine(f.GetTop());
        Console.WriteLine(f.GetBottom());
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        
        Random random = new Random();
        Fraction f2 = new Fraction();
        for (int i = 0; i <3; i++)
        {
            int top = random.Next(1,11);
            int bottom = random.Next(1, 11);
            f2.SetTop(top);
            f2.SetBottom(bottom);
            Console.Write($"Fractions {i + 1}: ");
            Console.Write($"String: {f2.GetFractionString()}, ");
            Console.Write($"Number: {f2.GetDecimalValue()}\n");

        }
    }
}