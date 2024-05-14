namespace BusinessLogic;

public class MaterialHandler
{
    private List<string> _validMaterials;
    private Dictionary<string, int> _materialCosts;

    public int GetMaterialCost(string material)
    {
        if (_materialCosts.ContainsKey(material))
        {
            return _materialCosts[material];
        }
        else
        {
            return 0; 
        }
    }
    

    public MaterialHandler()
    {
        _validMaterials = new List<string> { "Wood", "Metal", "Plastic" };
        _materialCosts = new Dictionary<string, int>
        {
            { "Wood", 5 },
        };
    }
}