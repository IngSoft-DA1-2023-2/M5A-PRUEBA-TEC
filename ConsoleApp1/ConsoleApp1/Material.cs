namespace ConsoleApp1;

public class Material
{
    public Material()
    {
    }
    
    public Material(string name, float price)
    {
        Name = name;
        Price = price;
    }
    
    public string Name { get; set; }
    public float Price { get; set; }
    
}