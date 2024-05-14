namespace BusinessLogic;

public class Tile
{
    private Shape _shape;
    private Material _material;
    private int ceramicCost = 10;
    private int porcelainCost = 15;
    private int squareLength = 10;
    private int squareWidth = 10;
    private int rectangleLength = 10;
    private int rectangleWidth = 20;

    public Tile() { }
    public Tile(Shape shape, Material material)
    {
        Shape = shape;
        Material = material;
    }
    
    public Shape Shape
    {
        get => _shape;
        set
        {
            ShapeIsEmptyOrNull(value);
            InvalidShape(value);
            _shape = value;
        }
    }
    
    public Material Material
    {
        get => _material;
        set
        {
            MaterialIsEmptyOrNull(value);
            InvalidMaterial(value);
            _material = value;
        }
    }
    
    public void ShapeIsEmptyOrNull(Shape shape)
    {
        if (shape == null || shape.ToString() == string.Empty)
        {
            throw new ArgumentException("Shape is null or an empty field");
        }
    }
    
    public void InvalidShape(Shape shape)
    {
        if (!Enum.IsDefined(typeof(Shape), shape))
        {
            throw new ArgumentException("Invalid shape");
        }
    }

    public void MaterialIsEmptyOrNull(Material material)
    {
        if (material == null || material.ToString() == string.Empty)
        {
            throw new ArgumentException("Material is null or an empty field");
        }
    }
    
    public void InvalidMaterial(Material material)
    {
        if (!Enum.IsDefined(typeof(Material), material))
        {
            throw new ArgumentException("Invalid material");
        }
    }
    
    public double CalculateTilePrice(int quantity, Material material)
    {
        int price = 0;
        if (material == Material.Ceramic)
        {
            price = quantity * ceramicCost;
        }
        else if (material == Material.Porcelain)
        {
            price = quantity * porcelainCost;
        }

        return price;
    }
    
    public int CalculateArea(int quantity, Shape shape)
    {
        int totalArea = 0;
        if (shape == Shape.Square)
        {
            totalArea = squareLength * squareWidth * quantity;
        }
        else if (shape == Shape.Rectangle)
        {
            totalArea = rectangleLength* rectangleWidth * quantity;
        }
        return totalArea;
    }
    
    
}