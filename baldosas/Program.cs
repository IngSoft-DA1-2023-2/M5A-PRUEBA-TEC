namespace Baldosas;

        
public class Material
{
    public string Nombre { get; set; }
    public int Precio { get; set; }

    public Material(string nombre, int precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

public abstract class Baldosa
{
    public Material Material { get; set; }
    public abstract int Area();

    public int Precio()
    {
        return this.Area() * this.Material.Precio;
    }
}

public class BaldosaCuadrada : Baldosa
{
    public int Lado { get; set; }
    public override int Area()
    {
        return Lado * Lado;
    }
}

        public class Program
        {
            public static void Main(string[] args)
            {
            }
        }
