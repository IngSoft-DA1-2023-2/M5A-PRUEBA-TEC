namespace BusinessLogic;

public class TileCalculator
{
    private Dictionary<Material, double> MaterialPrices { get; }
    
    public TileCalculator(Dictionary<Material, double> materialPrices)
    {
        MaterialPrices = materialPrices;
    }
    
    public double CalculateTotalPrice(IEnumerable<Tile> tiles)
    {
        var tileList = tiles.ToList();
        if (tileList.Any(tile => !MaterialPrices.ContainsKey(tile.Material)))
        {
            throw new KeyNotFoundException("Unknown material price.");
        }
        return tileList.Sum(CalculateTilePrice);
    }
    
    public static double CalculateTotalArea(IEnumerable<Tile> tiles)
    {
        return tiles.Sum(tile => tile.CalculateArea());
    }

    private double CalculateTilePrice(Tile tile)
    {
        return tile.CalculateArea() * MaterialPrices[tile.Material];
    }
}