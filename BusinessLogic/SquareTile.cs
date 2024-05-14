namespace BusinessLogic;

public class SquareTile : Tile
{
    private double Width { get; }
    
    public SquareTile(Material material, double width)
    {
        Width = width;
        Material = material;
    }
    
    public override double CalculateArea()
    {
        return Width * Width;
    }
}