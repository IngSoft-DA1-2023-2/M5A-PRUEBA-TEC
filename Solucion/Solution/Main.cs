namespace Solucion;

public class Main
{
    private List<Tile> Tiles { get; set; }
    
       public Main()
        {
            Tiles = new List<Tile>();
            
        }
       
       public void AddTile(Tile tile)
       {
           Tiles.Add(tile);
       }
       
       public double CalculateTotal()
       {
           double total = 0;
           foreach (Tile tile in Tiles)
           {
               total += tile.CalculateTotalPrice();
           }
           return total;
       }
}