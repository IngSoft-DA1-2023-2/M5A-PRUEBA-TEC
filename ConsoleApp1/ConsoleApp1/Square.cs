namespace ConsoleApp1;

public class Square : Shape
{
    
    public Square()
    {
    }
    
    
    public Square(int width, int height, Material material)
    {
        Width = width;
        Height = height;
        Material = material;
    }
    
    public int Width { get; set; }
    
    public int Height { get; set; }
    
    public override float Area()
    {
        return Width*Height;
    }

    public override float Price()
    {
        return (Height*Width)* Material.Price;
    }
}