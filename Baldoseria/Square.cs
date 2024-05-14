namespace Baldoseria;

public class Square : Shape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }
    
    public override double AreaCalculate()
    {
        return Side * Side;
    }
    
}