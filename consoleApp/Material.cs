namespace consoleApp;

public class Material{

    private double? _materialPrice;
    private string? _materialName;
    public Material(){}

    public Material(string? name, double? materialPrice){
        _materialName = name;
        if(materialPrice < 0){
            throw new ArgumentException("El precio de un material no puede ser negativo");
        }
        _materialPrice = materialPrice;
    }

    public double? MaterialPrice
    {
        get{return _materialPrice;}

        set{
            if(value < 0){
                throw new ArgumentException("El precio de un material no puede ser negativo");
            }else{
                _materialPrice = value;
            }
            
        }
    }

    public string? MaterialName
    {
        get{return _materialName;}

        set{
            _materialName = value;
        }
    }
}