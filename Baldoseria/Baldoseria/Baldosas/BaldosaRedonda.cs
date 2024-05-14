namespace Baldoseria.Baldosas;

public class BaldosaRedonda: Baldosa
{
    int Radio { get; set; }
    
    public BaldosaRedonda(Material materialType) : base(materialType)
    {
    }
    
    public override int CalcularArea()
    {
        return (int) (Math.PI * Math.Pow(Radio, 2));
    }
}