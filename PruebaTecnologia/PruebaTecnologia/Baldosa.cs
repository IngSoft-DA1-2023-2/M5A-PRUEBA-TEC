namespace PruebaTecnologia;

public class Baldosa
{
    private Material _material;
    private Forma _forma;
    private float _area;
    private float _precio;
    
    public Baldosa(Forma forma,Material material)
    {
        _forma = forma;
        _material = material;
    }
    
    public Forma Forma
    {
        get => _forma;
        set
        {
            _forma=value;
        }
    }
    public Material Material
    {
        get => _material;
        set
        {
            _material=value;
        }
    }
    
    public void CalcularAreaCuadrado(float lado)
    {
        _area= lado * lado;
    }
    
    public void CalcularAreaRectangulo(float lado1, float lado2)
    {
        _area= lado1 * lado2;
    }
    
    public float Area
    {
        get => _area;
      
    }
    public void Calcularprecio()
    {
        _precio = _material.PrecioMaterial * _area;
    }
    
  

}