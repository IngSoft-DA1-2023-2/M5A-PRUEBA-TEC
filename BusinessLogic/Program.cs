using BusinessLogic;

var materialCosts = new Dictionary<Material, double>
{
    { Material.Ceramic, 5.0 },
    { Material.Porcelain, 10.0 },
    { Material.Stone, 20.0 }
};

var tileCalculator = new TileCalculator(materialCosts);

var tiles = new List<Tile>
{
    new SquareTile(Material.Ceramic, 10),
    new RectangularTile(Material.Stone, 10, 20),
    new SquareTile(Material.Porcelain, 5)
};

Console.WriteLine("Material Costs:");
foreach (var materialCost in materialCosts)
{
    Console.WriteLine($"{materialCost.Key}: {materialCost.Value}$ / square meter");
}

Console.WriteLine("Tiles:");
foreach (var tile in tiles)
{
    Console.WriteLine($"Tile made of {tile.Material}. Area: {tile.CalculateArea()} square meters");
}

Console.WriteLine("Total area:");
Console.WriteLine(TileCalculator.CalculateTotalArea(tiles));

Console.WriteLine("Total price:");
Console.WriteLine(tileCalculator.CalculateTotalPrice(tiles));