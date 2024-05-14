namespace Baldoseria;

public enum Material
{
    Ceramica,
    Piedra
}

public static class MaterialCost
{
    public static Dictionary<Material, int> Costs = new Dictionary<Material, int>
    {
        { Material.Ceramica, 10 },
        { Material.Piedra, 20 }
    };
}