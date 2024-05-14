namespace Ejecicio;

public class CircleTie : Tie
{
    private int _radius;

    public int Radius
    {
        get => _radius;
        set => _radius = value;
    }
    
    public CircleTie(int radius)
    {
        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    

    
}