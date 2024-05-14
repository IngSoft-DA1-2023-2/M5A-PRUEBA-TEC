namespace BusinessLogic;

public abstract class Tile
{
    public Material Material { protected init; get; }
    public abstract double CalculateArea();
}