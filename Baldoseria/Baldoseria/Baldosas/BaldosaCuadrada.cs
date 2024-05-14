namespace Baldoseria.Baldosas;

public class BaldosaCuadrada: Baldosa
{
    int Lado { get; set; }
    
    public BaldosaCuadrada(Material materialType) : base(materialType)
    {
    }
    
    public override int CalcularArea()
    {
        return Lado * Lado;
    }
}