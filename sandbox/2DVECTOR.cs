class Vector2D
{
    private int X;
    private int Y;

    public Vector2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string GetVector2DDisplayString()
    {
        return $"x: {X}, y: {Y}";
    }

    public static Vector2D operator + (Vector2D v1, Vector2D v2);
}