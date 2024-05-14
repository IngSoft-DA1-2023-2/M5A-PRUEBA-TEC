namespace BusinessLogic;

public class Square : Shape
{
    public Square ()
    {
        MaterialHandler = new MaterialHandler();
    }
    public MaterialHandler MaterialHandler { get; set; }
    
    public int Area()
    {
        return Side * Side;
    }

    public int CalculateCost()
    {
        return Area() * MaterialHandler.GetMaterialCost(Material);
    }
    
    
}