namespace ConsoleApp1;

public abstract class Shape
{
    public Shape()
    {
    }
    
    public Shape(Material material)
    {
        Material = material;
    }
    
    public Material Material { get; set; }
    
    public abstract float Area();
    public abstract float Price();

}