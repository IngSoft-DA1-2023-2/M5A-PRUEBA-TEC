namespace Prueba;

public class Tile
{
    public IShape Shape { get; set; }
    public Material Material { get; set; }
    
    public Tile(IShape shape, Material material)
    {
        Shape = shape;
        Material = material;
    }
    
    public int CalculatePrice()
    {
        return (int) (Shape.CalculateArea() * Material.Price);
    }
}