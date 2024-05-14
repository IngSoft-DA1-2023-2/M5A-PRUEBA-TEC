namespace Baldoseria;

public class Shape
{
    private double _length;
    private double _width;

    public double Length
    {
        get => _length;
        set => _length = value;
    }
    
    public double Width
    {
        get => _width;
        set => _width = value;
    }
    
    public Shape()
    {
        
    }
    
    public virtual double AreaCalculate()
    {
        return _length * _width;
    }
    
}