namespace PruebaTecnologia;

public class Material
{
    private string _material;
    private float _precioMaterial;
    
    public Material(string material, float precioMaterial)
    {
        _material = material;
        _precioMaterial = precioMaterial;
    }
    public float PrecioMaterial
    {
        get => _precioMaterial;
        set
        {
            _precioMaterial=value;
        }
    }
    
    public string TipoMaterial
    {
        get => _material;
        set
        {
            _material=value;
        }
    }
}