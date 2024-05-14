namespace Logic;

public class Shape
{
    public String ShapeName { get; set; }
    public int[] Dimensions { get; set; }
    public int Area { get; set; }
    
    public Shape(String shapeName, params int[] dimensions)
    {
        ShapeName = shapeName;
        Dimensions = dimensions;
        Area = calculateArea();
    }
    
    private int calculateArea()
    {
        int area = 0;
        if (ShapeName == "Square")
        {
            area = Dimensions[0] * Dimensions[0];
        } else if (ShapeName == "Rectangle")
        {
            area = Dimensions[0] * Dimensions[1];
        }
        return area;
    }
}