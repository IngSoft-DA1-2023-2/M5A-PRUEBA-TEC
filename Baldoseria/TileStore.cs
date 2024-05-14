namespace Baldoseria;

public class TileStore
{
    private List<Tile> _tiles = new List<Tile>();
    
    public void AddTile(Tile tile)
    {
        _tiles.Add(tile);
    }
    
    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Tile tile in _tiles)
        {
            totalPrice += tile.Price;
        }
        return totalPrice;
    }
    
    public double CalculateTotalArea()
    {
        double totalArea = 0;
        foreach (Tile tile in _tiles)
        {
            totalArea += tile.Area;
        }
        return totalArea;
    }
    
    public List<Tile> Tiles
    {
        get => _tiles;
    }
    
    public void TotalTilesPrice()
    {
        Console.WriteLine($"Total price of all tiles: {CalculateTotalPrice()}");
    }
    
}