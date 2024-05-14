using Domain.Enums;

namespace Domain;

public class Baldosa
{
    public Material Material { get; set; }
    public FormaFormaEnum Forma { get; set; }
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    
    public Baldosa(Material material, FormaFormaEnum forma, double lado1, double lado2 = 0)
    {
        Material = material;
        Forma = forma;
        Lado1 = lado1;
        Lado2 = lado2;
    }
    
    public double GetCostoPorBaldosa()
    {
        double costoPorTamanio = CalculateArea() * CostoTamanioCalculator.GetCostoPorTamanio(Material);
        return costoPorTamanio;
    }
    
    public double CalculateArea()
    {
        switch (Forma)
        {
            case FormaFormaEnum.Circle:
                return FormaAreaCalculator.CalculateCircleArea(Lado1);
            case FormaFormaEnum.Square:
                return FormaAreaCalculator.CalculateSquareArea(Lado1);
            case FormaFormaEnum.Rectangle:
                return FormaAreaCalculator.CalculateRectangleArea(Lado1, Lado2);
            default:
                return 0;
        }
        // Si se agrega una nueva forma, hay que agregar un nuevo case
    }
}