using System.Runtime.CompilerServices;

namespace BusinessLogic.Classes;

public class BaldosaCuadrada:Baldosa
{
    public BaldosaCuadrada(int lado, Material material):base(lado,lado,material){}

    public override int CalcularArea(){
        int area = Largo * Ancho;
        return area;
    }

    public override int CalcularPrecio(){
        int area = CalcularArea();
        int precio = Material.PrecioMetroCuadrado * area;
        return precio;
    }
}
