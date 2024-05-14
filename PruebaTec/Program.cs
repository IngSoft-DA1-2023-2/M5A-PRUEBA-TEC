// See https://aka.ms/new-console-template for more information
using BusinessLogic;
Console.WriteLine("Hello, World!");

var lista = new List<Tile>();

lista.Add(new SquareTile(Material.Stone, 10));
lista.Add(new SquareTile(Material.Ceramic, 10));
lista.Add(new SquareTile(Material.Stone, 20));
lista.Add(new SquareTile(Material.Ceramic, 20));


float total = 0;
foreach (var tile in lista)
{
    Console.WriteLine($"Material: {tile.Material}, Shape: {tile.Shape}, Area: {tile.Area}, Price: {tile.Price}");
    total += tile.Price;
}

Console.WriteLine($"Total: {total}");