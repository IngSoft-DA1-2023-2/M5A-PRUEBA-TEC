using consoleApp;
namespace BackendTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestCreateMaterial()
    {
        var material = new Material();
        Assert.IsNotNull(material);
    }

    [TestMethod]
    public void TestCreateMaterialWithValidPrice()
    {
        var price = 20;
        var name = "Porcelana";
        var material = new Material(name, price);
        Assert.AreEqual("Porcelana", material.MaterialName);
        Assert.AreEqual(20, material.MaterialPrice);
    }

    [TestMethod]
    public void TestCreateMaterialWithInvalidPrice()
    {
        var price = -20;
        var name = "Porcelana";
        var exception = Assert.ThrowsException<ArgumentException>
        (() =>
        {
            var material = new Material(name, price);
        });
        Assert.AreEqual("El precio de un material no puede ser negativo", exception.Message);
    }

    [TestMethod]
    public void TestValidMaterialPriceProperty()
    {
        var validPrice = 20;
        var material = new Material();
        material.MaterialPrice = validPrice;
        Assert.AreEqual(validPrice, material.MaterialPrice);
    }

    [TestMethod]
    public void TestInvalidMaterialPriceProperty()
    {
        var invalidPrice = -20;
        var exception = Assert.ThrowsException<ArgumentException>
        (() =>
        {
            var material = new Material();
            material.MaterialPrice = invalidPrice;
        });
        Assert.AreEqual("El precio de un material no puede ser negativo", exception.Message);
    }

    [TestMethod]
    public void TestValidMaterialNameProperty()
    {
        var validName = "Porcelana";
        var material = new Material();
        material.MaterialName = validName;
        Assert.AreEqual(validName, material.MaterialName);
    }

    [TestMethod]
    public void TestCreateShape()
    {
        var shape = new Shape();
        Assert.IsNotNull(shape);
    }
    
}