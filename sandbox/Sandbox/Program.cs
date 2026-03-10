using System;
class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("circle");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine(myCircle.GetRadius());
        myCircle._radius = 900;
        Circle myCircle2 = new Circle();

        myCircle2.SetRadius(99999);
        Console.WriteLine(myCircle2.GetRadius());

        Console.WriteLine(myCircle2.GetCircumference());

        Console.WriteLine(myCircle2.GetArea());
        Console.WriteLine(myCircle2.GetDiameter()); //circle: class, get diameter: object
    }
}