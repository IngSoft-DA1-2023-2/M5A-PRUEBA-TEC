namespace BusinessLogic;

public abstract class Tile
{
    private Material _material;
    private Shape _shape;
    private float _price;
    private float _area;

    protected Tile(Material material, Shape shape)
    {
        _material = material;
        _shape = shape;
    }

    public virtual Material Material
    {
        get => _material;
        set => _material = value;
    }

    public virtual Shape Shape
    {
        get => _shape;
        set => _shape = value;
    }

    public virtual float Price
    {
        get => _price;
        set => _price = value;
    }

    public virtual float Area
    {
        get => _area;
        set => _area = value;
    }

    public abstract float CalculateArea();
}