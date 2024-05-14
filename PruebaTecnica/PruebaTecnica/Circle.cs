namespace PruebaTecnica;

public class Circle : Tile
{
    public int Radio { get; set; }
    public override Material material { get; set; }
    public Circle(int radio)
    {
        Radio = radio;
    }

    public override double CalculateArea()
    {
        return Radio * Radio * 3.14;
    }
}