namespace Baldoseria;

public class Shape
{
    private double _length;
    private double _width;
    private double _radius;
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
    
    public double Radius
    {
        get => _radius;
        set => _radius = value;
    }
    
    public Shape()
    {
        
    }
    
    
    public virtual double AreaCalculate()
    {
        return _length * _width;
    }
    
    
}