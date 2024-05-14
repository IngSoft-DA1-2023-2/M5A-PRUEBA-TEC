namespace BusinessLogic;

public class Square : Shape
{
    public int Side { set; get; }
    
    public int Area()
    {
        return Side * Side;
    }
}