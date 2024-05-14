namespace Prueba.Shapes;

public class Square : IShape
{
    public int Width { get; set; }

    public Square(int width)
    {
        Width = width;
        EnsureAreaIsPositive();
    }

    public int CalculateArea()
    {
        return Width * Width;
    }

    public void EnsureAreaIsPositive()
    {
        if (Width < 0)
        {
            throw new InvalidOperationException("Area must be positive");
        }
    }
}
