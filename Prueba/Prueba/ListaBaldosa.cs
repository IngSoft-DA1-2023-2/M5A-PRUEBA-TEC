namespace Prueba;

public class ListaBaldosa
{
    private List<Baldosa> _baldosas = new List<Baldosa>();
    
    public void AddBaldosa(Baldosa baldosa)
    {
        _baldosas.Add(baldosa);
    }
    
    public List<Baldosa> Baldosas
    {
        get => _baldosas;
    }
}