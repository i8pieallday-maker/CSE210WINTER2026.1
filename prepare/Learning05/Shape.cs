
abstract class Shape
{
    private string _color;
    private double _side;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    // public double GetSide()
    // {
    //     Console.WriteLine("What's the width? ");
    //     double _side = double.Parse(Console.ReadLine());
    //     return _side;
    // }

    public void SetColor(string color)
    {
        _color = color;
    }

    // public void SetSide(double side)
    // {
    //     _side = side;
    // }

    public abstract double GetArea();

}