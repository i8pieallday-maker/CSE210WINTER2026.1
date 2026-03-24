
class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double Area = Math.Round(Math.PI * _radius * _radius, 2);
        return Area;
    }
}