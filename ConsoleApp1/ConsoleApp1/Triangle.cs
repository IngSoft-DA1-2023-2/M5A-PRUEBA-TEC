namespace ConsoleApp1;

public class Triangle : Shape
{
    public Triangle()
    {
    }
    
    public Triangle(int width, int height, Material material)
    {
        Width = width;
        Height = height;
        Material = material;
    }
    
    public int Width { get; set; }
    
    public int Height { get; set; }
    
    public override float Area()
    {
        return (Width*Height)/2;
    }

    public override float Price()
    {
        return ((Width*Height)/2) * Material.Price;
    }
}