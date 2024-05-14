namespace Baldoseria;

public class App
{
    public static List<Baldosas.Baldosa> Baldosas = new List<Baldosas.Baldosa>();
    
    public static void AgregarBaldosa(Baldosas.Baldosa baldosa)
    {
        Baldosas.Add(baldosa);
    }

    public static double CalcularAreaTotal()
    {
        double areaTotal = 0;
        foreach (Baldosas.Baldosa baldosa in Baldosas)
        {
            areaTotal += baldosa.CalcularArea();
        }
        return areaTotal;
    }

    public static int CalcularPrecioTotal()
    {
        int precioTotal = 0;
        foreach (Baldosas.Baldosa baldosa in Baldosas)
        {
            precioTotal += baldosa.CalcularCosto() * baldosa.CalcularArea();
        }
        return precioTotal;
    }
}