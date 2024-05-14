using Logic;

namespace LogicTests;

[TestClass]
public class ShapeTestsSquare
{
    [TestMethod]
    public void CreateNewShapeWithValidShapeName()
    {
        // Arrange
        int[] dimensions = new int[1];
        dimensions[0] = 8;
        Shape shape = new Shape("Square", dimensions);
    
        // Act & Assert
        Assert.AreEqual(shape.ShapeName, "Square");
    }
    
    [TestMethod]
    public void CreateNewShapeWithValidDimension()
    {
        // Arrange
        int[] dimensions = new int[1];
        dimensions[0] = 8;
        Shape shape = new Shape("Square", dimensions);
    
        // Act & Assert
        Assert.AreEqual(shape.Dimensions[0], 8);
    }
    
    [TestMethod]
    public void CreateNewShapeWithValidArea()
    {
        // Arrange
        int[] dimensions = new int[1];
        dimensions[0] = 8;
        Shape shape = new Shape("Square", dimensions);
    
        // Act & Assert
        Assert.AreEqual(shape.Area, 64);
    }
}

[TestClass]
public class ShapeTestsRectangle
{
    [TestMethod]
    public void CreateNewShapeWithValidShapeName()
    {
        // Arrange
        int[] dimensions = new int[2];
        Shape shape = new Shape("Rectangle", dimensions);
        dimensions[0] = 8;
        dimensions[1] = 2;
    
        // Act & Assert
        Assert.AreEqual(shape.ShapeName, "Rectangle");
    }
    
    [TestMethod]
    public void CreateNewShapeWithValidDimension()
    {
        // Arrange
        int[] dimensions = new int[2];
        dimensions[0] = 8;
        dimensions[1] = 2;
        Shape shape = new Shape("Rectangle", dimensions);
    
        // Act & Assert
        Assert.AreEqual(shape.Dimensions[0], 8);
    }
    
    [TestMethod]
    public void CreateNewShapeWithValidArea()
    {
        // Arrange
        int[] dimensions = new int[2];
        dimensions[0] = 8;
        dimensions[1] = 2;
        Shape shape = new Shape("Rectangle", dimensions);
    
        // Act & Assert
        Assert.AreEqual(shape.Area, 16);
    }
}