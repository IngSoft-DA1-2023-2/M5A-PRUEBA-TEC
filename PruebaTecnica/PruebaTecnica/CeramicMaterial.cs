namespace PruebaTecnica;

public class CeramicMaterial : Material
{
    public override string Name { get; set; }
    public override double Price { get; set; }

    public CeramicMaterial(string name, double price)
    {
        Name = name;
        Price = price;
    }
}