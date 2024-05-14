namespace Prueba;

public class MaterialPrecio
{
    private Material _material;
    private int _precio;
    
    public MaterialPrecio() { }
    
    public MaterialPrecio(Material material, int precio)
    {
        _material = material;
        _precio = precio;
    }
    
    public Material Material
    {
        get => _material;
        set
        {
            ValidateMaterial(value);
            _material = value;
        }
    }
    
    public void ValidateMaterial(Material material)
    {
        if (!Enum.IsDefined(typeof(Material), material))
        {
            throw new ArgumentException("Invalid material");
        }
    }
    
    public int Precio
    {
        get => _precio;
        set
        {
            ValidatePrecio(value);
            _precio = value;
        }
    }
    
    public void ValidatePrecio(int precio)
    {
        if (precio <= 0)
        {
            throw new ArgumentException("Invalid precio");
        }

        if(Material.Porcelana == _material)
        {
            _precio = 10;
        }else if(Material.Ceramica == _material)
        {
            _precio = 20;
        }
    }
}