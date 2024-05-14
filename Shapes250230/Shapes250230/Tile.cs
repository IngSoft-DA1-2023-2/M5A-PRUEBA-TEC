namespace Shapes250230;

public class Tile
{
    public Tile()
    {
        
    }

    private string _material;
    public string Material
    {
        get => _material;
        set => _material = value;
    }


    private string _shape;
    public string Shape
    {
        get => _shape;
        set => _shape = value;
    }
    
    private float _area;
    public float Area
    {
        get => _area;
        set => _area = value;
    }
    
    private float _materialPrice;
    public float MaterialPrice
    {
        get => _materialPrice;
        set => _materialPrice = value;
    }

    public float GetSingleTilePrice()
    {
        return _materialPrice * _area;
    }
}