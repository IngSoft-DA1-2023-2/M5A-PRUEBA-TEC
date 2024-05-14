namespace Logic;

public class Material
{
    public String MatirialName { get; set; }
    public int MaterialCost { get; set; }
    
    public Material(String materialName, int materialCost)
    {
        MatirialName = materialName;
        MaterialCost = materialCost;
    }
}