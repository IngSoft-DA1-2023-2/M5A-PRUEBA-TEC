using Baldoseria.Baldosas;

namespace Baldoseria.Test;

public class App_Test
{
    [TestMethod]
    public void AgregarBaldosaCuadrada()
    {
        // Arrange and Act
        App.AgregarBaldosa(new BaldosaCuadrada(Material.Ceramica));
        // Assert
        Assert.AreEqual(1, App.Baldosas.Count);
    }
    
    [TestMethod]
    public void AgregarBaldosaCircular()
    {
        // Arrange and Act
        App.AgregarBaldosa(new BaldosaCuadrada(Material.Ceramica));
        // Assert
        Assert.AreEqual(1, App.Baldosas.Count);
    }
    
    [TestMethod]
    public void CalcularAreaTotalBaldosas()
    {
        // Arrange
        App.AgregarBaldosa(new BaldosaCuadrada(Material.Ceramica));
        App.AgregarBaldosa(new BaldosaRedonda(Material.Ceramica));
        
        // Act
        double area = App.CalcularAreaTotal();
        
        // Assert
        Assert.AreEqual(514.16, area, 0.01);
    }

    [TestMethod]
    public void CalcularPrecioTotalBaldosas()
    {
        // Arrange
        App.AgregarBaldosa(new BaldosaCuadrada(Material.Ceramica));
        App.AgregarBaldosa(new BaldosaRedonda(Material.Ceramica));
        
        // Act
        int precio = App.CalcularPrecioTotal();
        
        // Assert
        Assert.AreEqual(514.16, precio, 0.01);
    }
}