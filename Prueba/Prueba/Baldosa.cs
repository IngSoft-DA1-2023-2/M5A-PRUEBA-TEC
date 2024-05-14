namespace Prueba;

public class Baldosa
{
    private Forma _forma;
    private MaterialPrecio _materialPrecio;

    public Baldosa() { }
    
    public Baldosa(Forma forma, MaterialPrecio materialPrecio)
    {
        _forma = forma;
        _materialPrecio = materialPrecio;
   }
    
    public Forma Forma
    {
        get => _forma;
        set
        {
            ValidateForma(value);
            _forma = value;
        }
    }
    
    public void ValidateForma(Forma forma)
    {
        if (!Enum.IsDefined(typeof(Forma), forma))
        {
            throw new ArgumentException("Invalid forma");
        }
    }
    
    public MaterialPrecio MaterialPrecio
    {
        get => _materialPrecio;
        set
        {
            ValidateMaterialPrecioCeramica(value);
            ValidateMaterialPrecioPorcelana(value);
            _materialPrecio = value;
        }
    }
    
    public void ValidateMaterialPrecioCeramica(MaterialPrecio materialPrecio)
    {
        if(materialPrecio.Material == Prueba.Material.Ceramica && materialPrecio.Precio != 20)
        {
            throw new ArgumentException("Invalid price of ceramica");
        }
    }
    
    public void ValidateMaterialPrecioPorcelana(MaterialPrecio materialPrecio)
    {
        if(materialPrecio.Material == Prueba.Material.Porcelana && materialPrecio.Precio != 10)
        {
            throw new ArgumentException("Invalid price of porcelana");
        }
    }
    
    
    
}