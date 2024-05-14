namespace Baldoseria;

public class Area
{
    
    
    public Area()
    {
        
    }
    
    public double SquareAreaCalculate(double side)
    {
        return side * side;
    }
    
    public double RectangleAreaCalculate(double length, double width)
    {
        return length * width;
    }
    
    public double CircleAreaCalculate(double radius)
    {
        return Math.PI * radius * radius;
    }
    
}