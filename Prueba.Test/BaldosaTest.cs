namespace Prueba.Test;

[TestClass]
public class BaldosaTest
{
    [TestMethod]
    public void CreateBaldosaTest()
    {
        var baldosa = new Baldosa();

        Assert.IsNotNull(baldosa);
    }

    [TestMethod]
    public void CreateBaldosaWithParametersTest()
    {
        var forma = Forma.Cuadrado;
        var material = Material.Ceramica;
        int precio = 20;
        MaterialPrecio materialPrecio = new MaterialPrecio(material, precio);
        var baldosa = new Baldosa(forma, materialPrecio);
        Assert.IsNotNull(baldosa);
    }

    [TestMethod]
    public void CreateBaldosaWithAllAtributtes()
    {
        var forma = Forma.Cuadrado;
        
        const Material material = Material.Ceramica;
        int precio = 20;
        var materialPrecio = new MaterialPrecio(material, precio);
        var baldosa = new Baldosa()
        {
            Forma = forma,
            MaterialPrecio = materialPrecio
        };
        Assert.AreEqual(baldosa.Forma, forma);
        Assert.AreEqual(baldosa.MaterialPrecio, materialPrecio);
    }

    [TestMethod]
    public void ValidateFormaTest()
    {
        const Forma forma = (Forma)999;
        const Material material = Material.Ceramica;
        int precio = 20;
        var materialPrecio = new MaterialPrecio(material, precio);
        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            var baldosa = new Baldosa()
            {
                Forma = forma,
                MaterialPrecio = materialPrecio,
            };
        });
        Assert.AreEqual("Invalid forma", exception.Message);
    }

    [TestMethod]
    public void ValidateMaterialPrecioCeramicaTest()
    {
        const Forma forma = Forma.Cuadrado;
        const Material material = Material.Ceramica;
        int precio = 19;
        var materialPrecio = new MaterialPrecio(material, precio);
        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            var baldosa = new Baldosa()
            {
                Forma = forma,
                MaterialPrecio = materialPrecio,
            };
        });
        Assert.AreEqual("Invalid price of ceramica", exception.Message);
    }
    
    [TestMethod]
    public void ValidateMaterialPrecioPorcelanaTest()
    {
        const Forma forma = Forma.Cuadrado;
        const Material material = Material.Porcelana;
        int precio = 19;
        var materialPrecio = new MaterialPrecio(material, precio);
        var exception = Assert.ThrowsException<ArgumentException>(() =>
        {
            var baldosa = new Baldosa()
            {
                Forma = forma,
                MaterialPrecio = materialPrecio,
            };
        });
        Assert.AreEqual("Invalid price of porcelana", exception.Message);
    }
}