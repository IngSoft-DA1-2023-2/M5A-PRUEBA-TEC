namespace Ejecicio;

public static class Calculator
{
    
    private static Dictionary<Material,int> prices = new Dictionary<Material, int>
    {
        {Material.Wood, 100},
        {Material.Stone, 200},
        {Material.Ceramic, 300}
    };
    
    public static double CalculateTotalPrice(List<Tie> shapes)
    {
        double total = 0;
        foreach (var shape in shapes)
        {
            total += prices[shape.Material] * shape.CalculateArea();
        }

        return total;
    } 
    
    public static double CalculateTotalArea(List<Tie> shapes)
    {
        double total = 0;
        foreach (var shape in shapes)
        {
            total += shape.CalculateArea();
        }

        return total;
    }
    
    
}