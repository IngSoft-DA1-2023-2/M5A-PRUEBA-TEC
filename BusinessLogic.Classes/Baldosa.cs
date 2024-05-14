namespace BusinessLogic.Classes;

public abstract class Baldosa
{
    public Baldosa(int largo, int ancho, Material material){
        Largo = largo;
        Ancho = ancho;
        Material = material;
    }
    public int Largo { get; set; }
    public int Ancho {get; set;}

    public Material Material{get;set;}

    public abstract int CalcularArea();
    public abstract int CalcularPrecio();
}
