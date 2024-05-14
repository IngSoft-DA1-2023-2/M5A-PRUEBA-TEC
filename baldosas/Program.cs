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

public class BaldosaTriangular : Baldosa
{
    public int Base { get; set; }
    public int Altura { get; set; }
    public override int Area()
    {
        return ((Base * Altura)/2);
    }
}

        public class Program
        {
            public static void Main(string[] args)
            {
                var ceramica = new Material("ceramica", 10);
                
                var baldosas = new List<Baldosa>{
                    new BaldosaCuadrada { Lado = 5, Material = ceramica },
                    new BaldosaTriangular { Base = 5, Altura = 10, Material = ceramica }
                };

                var areaTotal = 0;
                var precioTotal = 0;
                
                foreach (var baldosa in baldosas)
                {
                    areaTotal += baldosa.Area();
                    precioTotal += baldosa.Precio();
                }
                
                Console.WriteLine($"Area total: {areaTotal}");
                Console.WriteLine($"Precio total: {precioTotal}");
            }
        }
