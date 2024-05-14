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
}