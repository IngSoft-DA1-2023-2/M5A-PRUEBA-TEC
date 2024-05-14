using Baldoseria;

namespace Tests;

[TestClass]
public class MaterialTest
{
    [TestMethod]
    public void MaterialConstructor()
    {
        Material material = new Material("Ceramic", 10);
        Assert.IsNotNull(material);
    }
    
    [TestMethod]
    public void MaterialName()
    {
        Material material = new Material("Ceramic", 10);
        material.Name = "Marble";
        Assert.AreEqual("Marble", material.Name);
    }
    
    [TestMethod]
    public void MaterialPrice()
    {
        Material material = new Material("Ceramic", 10);
        material.Price = 20;
        Assert.AreEqual(20, material.Price);
    }
}