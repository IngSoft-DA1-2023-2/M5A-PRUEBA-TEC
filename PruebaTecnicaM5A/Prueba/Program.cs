using Prueba;
using Prueba.Materials;
using Prueba.Shapes;

List<Tile> tiles = new List<Tile>
{
    new Tile(new Square(10), new Stone()),
    new Tile(new Triangle(10, 5), new Ceramic()),
    new Tile(new Square(5), new Stone())
};

//Print individual tile prices and areas
foreach (Tile tile in tiles)
{
    Console.WriteLine($"Tile with {tile.Shape.GetType().Name} and " +
                      $"{tile.Material.Name} costs " +
                      $"{tile.Material.Price * tile.Shape.CalculateArea()} " +
                      $"with an area of {tile.Shape.CalculateArea()}");
}

//Print total price and area of all tiles
int totalPrice = tiles.Sum(tile => tile.CalculatePrice());
int totalArea = tiles.Sum(tile => tile.Shape.CalculateArea());
Console.WriteLine($"Total price of all tiles: {totalPrice}");
Console.WriteLine($"Total area of all tiles: {totalArea}");
