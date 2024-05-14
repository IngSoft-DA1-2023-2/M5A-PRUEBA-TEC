namespace Ejecicio;

public class SquareTie : Tie
{
    private int _side;

    public int Side
    {
        get => _side;
        set => _side = value;
    }
    
    public SquareTie(int side)
    {
        Side = side;
    }
    
    public override double CalculateArea()
    {
        return Side * Side;
    }
    
   
    
}