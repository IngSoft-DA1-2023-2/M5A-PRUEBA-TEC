namespace BusinessLogic;

public class RectangularTile : Tile
{
    private double Width { get; }
    private double Length { get; }
    
    public RectangularTile(Material material, double width, double length)
    {
        Material = material;
        Width = width;
        Length = length;
    }

    public override double CalculateArea()
    {
        return Width * Length;
    }
}