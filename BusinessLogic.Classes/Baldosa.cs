namespace BusinessLogic.Classes;

public abstract class Baldosa
{
    public Baldosa(int largo, int ancho){
        Largo = largo;
        Ancho = ancho;
    }
    public int Largo { get; set; }
    private int Ancho {get; set;}

    public abstract int CalcularArea();
    public abstract int CalcularPrecio();

}
