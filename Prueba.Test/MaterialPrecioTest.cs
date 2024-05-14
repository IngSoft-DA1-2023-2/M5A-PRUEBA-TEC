namespace Prueba.Test;

[TestClass]
public class MaterialPrecioTest
{
    [TestMethod]
    public void CreateMaterialPrecioTest()
    {
        var materialPrecio = new MaterialPrecio();

        Assert.IsNotNull(materialPrecio);
    }
    
    [TestMethod]
    public void CreateMaterialTestWithParametersTest()
    {
        Material material = Material.Ceramica;
        int precio = 20;
        var materialPrecio = new MaterialPrecio(material, 25);
        Assert.IsNotNull(materialPrecio);
    }
    
    [TestMethod]
    public void CreateMaterialTestWithAllAtributtes()
    {
        Material material = Material.Ceramica;
        int precio = 25;
        var materialPrecio = new MaterialPrecio()
        {
            Material = material,
            Precio = precio
        };
        Assert.AreEqual(materialPrecio.Material, material);
        Assert.AreEqual(materialPrecio.Precio, precio);

    }
    
    [TestMethod]
    public void ValidateMaterialTest()
    {
        const Material material = (Material)999;
        int precio = 10;
        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            var materialPrecio = new MaterialPrecio()
            {
                Material = material,
                Precio = precio
            };
        });
        Assert.AreEqual("Invalid material", exception.Message);
    }
    
    [TestMethod]
    public void ValidatePrecioTest()
    {
        Material material = Material.Ceramica;
        int precio = 0;
        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            var materialPrecio = new MaterialPrecio()
            {
                Material = material,
                Precio = precio
            };
        });
        Assert.AreEqual("Invalid precio", exception.Message);
    }

    [TestMethod]
    public void ValidatePrecioCeramicaTest()
    {
        Material material = Material.Ceramica;
        int precio = 20;
        var materialPrecio = new MaterialPrecio()
        {
            Material = material,
            Precio = precio
        };
        Assert.AreEqual(materialPrecio.Precio, precio);
    }
    [TestMethod]
    public void ValidatePrecioPircelanaTest()
    {
        Material material = Material.Porcelana;
        int precio = 10;
        var materialPrecio = new MaterialPrecio()
        {
            Material = material,
            Precio = precio
        };
        Assert.AreEqual(materialPrecio.Precio, precio);
    }
}