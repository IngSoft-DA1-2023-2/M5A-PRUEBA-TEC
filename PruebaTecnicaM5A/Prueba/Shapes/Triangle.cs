namespace Prueba.Shapes;

public class Triangle: IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Triangle(int width, int height)
    {
        Width = width;
        Height = height;
        EnsureAreaIsPositive();
    }

    public int CalculateArea()
    {
        return Width * Height / 2;
    }

    public void EnsureAreaIsPositive()
    {
        if (Width < 0 || Height < 0)
        {
            throw new InvalidOperationException("Area must be positive");
        }
    }
}