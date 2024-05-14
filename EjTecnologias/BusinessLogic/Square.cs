namespace BusinessLogic;

public class Square : Shape
{
    
    public int Area()
    {
        return Side * Side;
    }

    public int CalculateCost()
    {
        return 125;
    }
    
    
}