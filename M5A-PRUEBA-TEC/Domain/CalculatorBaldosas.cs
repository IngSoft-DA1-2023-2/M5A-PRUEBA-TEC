using Domain.Enums;

namespace Domain;

public class CalculatorBaldosas
{
    public List<Baldosa> Baldosas { get; set; }
    
    public CalculatorBaldosas()
    {
        Baldosas = new List<Baldosa>();
    }
    
    public void AddBaldosa(Baldosa baldosa)
    {
        Baldosas.Add(baldosa);
    }
    
    public double CalculateTotalArea()
    {
        double area = 0;
        
        foreach (var baldosa in Baldosas)
        {
            area += baldosa.CalculateArea();
        }
        
        return area;
    }
    
    public double CalculateTotalCosto()
    {
        double costo = 0;
        
        foreach (var baldosa in Baldosas)
        {
            costo += baldosa.GetCostoPorBaldosa();
        }
        
        return costo;
    }
}       