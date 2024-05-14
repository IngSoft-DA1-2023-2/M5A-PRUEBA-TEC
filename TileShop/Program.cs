namespace TileShop;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        // Parte 5
        var stone = new Material("Stone", 50);
        var concrete = new Material("Concrete", 200);
        var ceramic = new Material("Ceramic", 500);
        
        var rectangleTile = new RectangleTile(concrete, 5, 8);
        var squareTile = new SquareTile(stone, 5);
        var circleTile = new CircleTile(ceramic, 5);
    }
}