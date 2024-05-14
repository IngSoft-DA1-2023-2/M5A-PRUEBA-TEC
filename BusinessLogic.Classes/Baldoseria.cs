namespace BusinessLogic.Classes;

public class Baldoseria
{
    public List<Baldosa> Baldosas {get; set;}

    public Baldoseria(){
        Baldosas = new List<Baldosa>();
    }

    public void AgregarBaldosa(Baldosa baldosa){
        Baldosas.Add(baldosa);
    }

    public void RemoverBaldosa(Baldosa baldosa){
        Baldosas.Remove(baldosa);
    }

    public int CalcularAreaTotal(){
        int sumaArea = 0;
        foreach(Baldosa baldosa in Baldosas){
            int areaBaldosaActual = baldosa.CalcularArea();
            sumaArea+=areaBaldosaActual;
        }
        return sumaArea;
    }

    public int CalcularPrecioTotal(){
        int sumaPrecio = 0;
        foreach(Baldosa baldosa in Baldosas){
            int precioBaldosaActual = baldosa.CalcularPrecio();
            sumaPrecio+=precioBaldosaActual;
        }
        return sumaPrecio;
    }
    
}
