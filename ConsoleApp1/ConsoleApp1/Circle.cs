namespace ConsoleApp1;

public class Circle : Shape
{
    public Circle()
    {
    }
    
    public Circle(int radius, Material material)
    {
        Radius = radius;
        Material = material;
    }
    
    public int Radius { get; set; }
    
    public override float Area()
    {
        return (float) (Radius * Radius * Math.PI);
    }

    public override float Price()
    {
        return ((float) (Radius * Radius * Math.PI) * Material.Price);
    }
}