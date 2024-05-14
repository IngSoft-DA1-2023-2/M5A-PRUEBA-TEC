using ConsoleApp1;

namespace TestProject1;

[TestClass]
public class TringleTest
{
    [TestMethod]
    public void ShouldCreateTriangle()
    {
        Triangle triangle = new Triangle();

        Assert.IsNotNull(triangle);
    }
    
    [TestMethod]
    public void ShouldCreateTriangleWithMaterial()
    {
        Material material = new Material("ceramica", 100);
        Triangle triangle = new Triangle(10, 10, material);
        
        Assert.IsNotNull(triangle);
    }
    
    [TestMethod]
    public void ShouldGetTriangleMaterial()
    {
        Material material = new Material("ceramica", 100);
        Triangle triangle = new Triangle(10, 10, material);
        
        Assert.AreEqual(material, triangle.Material);
    }
    
    [TestMethod]
    public void ShouldGetTriangleArea()
    {
        Material material = new Material("ceramica", 100);
        Triangle triangle = new Triangle(10, 10, material);
        
        Assert.AreEqual(50, triangle.Area());
    }
    
    [TestMethod]
    public void ShouldGetTrianglePrice()
    {
        Material material = new Material("ceramica", 100);
        Triangle triangle = new Triangle(10, 10, material);
        
        Assert.AreEqual(5000, triangle.Price());
    }
}