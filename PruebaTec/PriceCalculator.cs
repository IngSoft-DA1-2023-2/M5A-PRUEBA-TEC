using System.Collections;

namespace BusinessLogic;

public static class PriceCalculator
{
    private static readonly Hashtable MaterialPrices = new Hashtable
    {
        {Material.Stone, 15f},
        {Material.Ceramic, 10f}
    };
    
    public static float CalculatePrice(Material material, float area)
    {
        return (float) MaterialPrices[material]! * area;
    }
}