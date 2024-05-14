namespace Baldoseria.Baldosas;

public abstract class Baldosa
{
    public virtual int Area { get; set; }
    
    public virtual Material MaterialType { get; set; }
    
    public Baldosa(Material materialType)
    {
        MaterialType = materialType;
        Area = CalcularArea();
    }

    public abstract int CalcularArea();

    public virtual int CalcularCosto()
    {
        return Area * MaterialCost.Costs[MaterialType];
    }
}