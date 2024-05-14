namespace Baldoseria;

public class Tile
{
    private Shape _shape;
    private Material _material;

    public Shape Shape
    {
        get => _shape;
        set => _shape = value;
    }
    
    public Material Material
    {
        get => _material;
        set => _material = value;
    }
    
    public double Area { get; set; }

    public double Price { get; set; }

    public Tile(Shape shape, Material material)
    {
        _shape = shape;
        _material = material;
        Area = shape.AreaCalculate();
        Price = CalculatePrice();
    }
    
    public double CalculatePrice()
    {
        return Area * Material.Price;
    }
}