namespace BusinessLogic;

public class Circle  : Shape
{
    public int Radius { get; set; }

    public override int Area()
    {
        return (int)(3.14 * Radius * Radius);
    }
    public override int CalculateCost()
    {
        return 0;
    }
}