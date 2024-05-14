namespace Baldoseria;

public class Material(string name, double price)
{
    public string Name
    {
        get => name;
        set => name = value;
    }
    
    public double Price
    {
        get => price;
        set => price = value;
    }
}