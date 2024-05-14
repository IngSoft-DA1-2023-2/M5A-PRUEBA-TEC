using Logic;

namespace LogicTests;

[TestClass]
public class MaterialTests
{
    [TestMethod]
    public void CreateNewMaterialWithValidMaterialName()
    {
        // Arrange
        Material material = new Material("Stone", 10);
        
        // Act & Assert
        Assert.AreEqual(material.MatirialName, "Stone");
    }
    
    [TestMethod]
    public void CreateNewMaterialWithValidMaterialNameForSteel()
    {
        // Arrange
        Material material = new Material("Steel", 10);
        
        // Act & Assert
        Assert.AreEqual(material.MatirialName, "Steel");
    }
    
    [TestMethod]
    public void CreateNewMaterialWithValidMaterialCost()
    {
        // Arrange
        Material material = new Material("Steel", 10);
        
        // Act & Assert
        Assert.AreEqual(material.MaterialCost, 10);
    }
}