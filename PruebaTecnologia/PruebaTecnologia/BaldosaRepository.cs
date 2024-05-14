namespace PruebaTecnologia;

public class BaldosaRepository
{
    private List<Baldosa> baldosas = new List<Baldosa>();
    
    public void AddBaldosa(Baldosa baldosa)
    {
        baldosas.Add(baldosa);
    }
    
    public List<Baldosa> Baldosas
    {
        get => baldosas;
    }
    
    
}