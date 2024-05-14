using ConsoleApp1;

namespace TestProject1;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void ShouldCreateCircle()
    {
        Circle circle = new Circle();

        Assert.IsNotNull(circle);
    }
    
    [TestMethod]
    public void ShouldCreateCircleWithParameters()
    {
        Material material = new Material("ceramica", 100);
        Circle circle = new Circle(10, material);
        
        Assert.IsNotNull(circle);
    }
    
    [TestMethod]
    public void ShouldGetCircleRadius()
    {
        Material material = new Material("ceramica", 100);
        Circle circle = new Circle(10, material);
        
        Assert.AreEqual(10, circle.Radius);
    }
    
    [TestMethod]
    public void ShouldGetCircleArea()
    {
        Material material = new Material("ceramica", 100);
        Circle circle = new Circle(10, material);
        
        Assert.AreEqual(314.15927, circle.Area(), 0.00001);
    }
    
    [TestMethod]
    public void ShouldGetCirclePrice()
    {
        Material material = new Material("ceramica", 100);
        Circle circle = new Circle(10, material);
        
        Assert.AreEqual(31415.927734375, circle.Price());
    }
}
