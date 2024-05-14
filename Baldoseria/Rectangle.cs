namespace Baldoseria;

public class Rectangle : Shape
{
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    
    public override double AreaCalculate()
    {
        return Length * Width;
    }
}