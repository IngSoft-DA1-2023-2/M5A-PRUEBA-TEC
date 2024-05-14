namespace BusinessLogic;

public abstract class Shape
{
    public string Material { set; get; }

    public abstract int Area();

    public abstract int CalculateCost();


}