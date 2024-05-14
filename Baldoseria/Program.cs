
using Baldoseria;

TileStore tileStore = new TileStore();

Tile tile1 = new Tile(new Square(5), new Material("Ceramic", 10));
Tile tile2 = new Tile(new Rectangle(5, 10), new Material("Marble", 20));
Tile tile3 = new Tile(new Square(10), new Material("Granite", 30));

tileStore.AddTile(tile1);
tileStore.AddTile(tile2);
tileStore.AddTile(tile3);

Console.WriteLine("Hello, Welcome to the Tile Store!");
Console.WriteLine("We have the following tiles available:");
Console.WriteLine("------------------------------------");
foreach (var tile in tileStore.Tiles)
{
    Console.WriteLine($"Tile: {tile.Shape} | Material: {tile.Material.Name} | Price: {tile.Price} | Area: {tile.Area}");
}
Console.WriteLine("------------------------------------");
Console.WriteLine($"Total price of all tiles: {tileStore.CalculateTotalPrice()}");



