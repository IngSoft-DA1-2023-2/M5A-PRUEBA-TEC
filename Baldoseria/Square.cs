namespace Baldoseria;

public class Square : Shape
{
    private double _side;
    
    public double Side
    {
        get => _side;
        set => _side = value;
    }
    
    public Square(double side)
    {
        _side = side;
    }
    
    public override double AreaCalculate()
    {
        return _side * _side;
    }
    
}