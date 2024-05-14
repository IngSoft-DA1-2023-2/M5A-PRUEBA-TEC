namespace Baldosas;

public class Piedra : IMaterial
{
    public int PrecioPorMetroCuadrado { get; set; }

    public Piedra(int precio)
    {
        this.PrecioPorMetroCuadrado = precio;
    }

    public double Precio()
    {
        return PrecioPorMetroCuadrado * 2;
    }
}