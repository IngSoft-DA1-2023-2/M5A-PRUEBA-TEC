using ConsoleApp1;

namespace TestProject1;

[TestClass]
public class MaterialTest
{
    [TestMethod]
    public void ShouldCreateMaterial()
    {
        Material material = new Material();

        Assert.IsNotNull(material);
    }

    [TestMethod]
    public void ShouldCreateMaterialWithParameters()
    {
        Material material = new Material("ceramica", 100);
        
        Assert.IsNotNull(material);
    }
    
    [TestMethod]
    public void ShouldGetMaterialName()
    {
        Material material = new Material("ceramica", 100);
        
        Assert.AreEqual("ceramica", material.Name);
    }
    
    [TestMethod]
    public void ShouldGetMaterialPrice()
    {
        Material material = new Material("ceramica", 100);
        
        Assert.AreEqual(100, material.Price);
    }
}