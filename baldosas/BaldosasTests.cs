using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Baldosas;

public class BaldosasTests
{
    private string _nombreMaterial = "Cerámica";
    private int _precioMaterial = 10;
    
    [TestMethod]
    public void Material_ShouldConstruct()
    {
        var material = new Material("Cerámica", 10);
        Assert.AreEqual(_nombreMaterial, material.Nombre);
        Assert.AreEqual(_precioMaterial, material.Precio);
    }
}


