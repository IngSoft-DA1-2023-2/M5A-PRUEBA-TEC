namespace Logic;

public class TileList
{
    public List<Tile> Tiles { get; set; }

    public TileList(List<Tile> tiles)
    {
        Tiles = tiles;
    }

    public int TotalCost
    {
        get
        {
            int totalCost = 0;
            foreach (var tile in Tiles)
            {
                totalCost += tile.Cost;
            }
            return totalCost;
        }
    }
}