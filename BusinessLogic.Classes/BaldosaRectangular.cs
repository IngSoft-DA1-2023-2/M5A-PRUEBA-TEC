namespace BusinessLogic.Classes;

public class BaldosaRectangular:Baldosa
{
    
    public BaldosaRectangular(int largo, int ancho, Material material):base(largo,ancho,material){}

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
