class Circle
{
    public double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("invalid radius");
            _radius = 0;
        }
        else
            _radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * +_radius *_radius;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * _radius;
    }
}