using Domain.Enums;

namespace Domain;

public class FormaAreaCalculator
{
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    
    public static double CalculateSquareArea(double side)
    {
        return Math.Pow(side, 2);
    }
    
    public static double CalculateRectangleArea(double side1, double side2)
    {
        return side1 * side2;
    }
    
    // Para añadir un nuevo tipo de forma, hay añadir un nuevo método para calcular su área
}