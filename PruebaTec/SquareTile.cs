namespace BusinessLogic;

public class SquareTile : Tile
{
    public SquareTile(Material material, float side) : base(material, Shape.Square)
    {
        Side = side;
        Area = CalculateArea();
        Price = PriceCalculator.CalculatePrice(material, Area);
    }

    public override float Price { get; set; }

    public override float Area { get; set; }

    private float Side { get; }

    public sealed override float CalculateArea()
    {
        return Side * Side;
    }
}