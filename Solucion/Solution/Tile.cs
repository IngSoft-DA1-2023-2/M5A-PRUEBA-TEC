namespace Solucion;

public class Tile
{
    public IShape Shape { get; set; }
    public IMaterial Material { get; set; }
    
    public Tile(IShape shape, IMaterial material)
    {
        Shape = shape;
        Material = material;
    }
    
    private double CalculateArea()
    {
        return Shape.CalculateArea();
    }
    
    private double CalculatePrice()
    {
        return Material.CalculatePrice();
    }
    
    public double CalculateTotalPrice()
    {
        return CalculateArea() * CalculatePrice();
    }
}