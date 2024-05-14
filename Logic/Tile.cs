namespace Logic;

public class Tile
{
    public Material Material { get; set; }
    public Shape Shape { get; set; }
    public int Cost { get; set; }
    
    public Tile(Material material, Shape shape)
    {
        Material = material;
        Shape = shape;
        Cost = calculateCost();
    }
    
    public int calculateCost()
    {
        return Material.MaterialCost * Shape.Area;
    }
}