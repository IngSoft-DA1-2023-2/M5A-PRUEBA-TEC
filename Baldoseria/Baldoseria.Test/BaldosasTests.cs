namespace Baldoseria.Test;

[TestClass]
public class BaldosasTests
{
    
    /*
     *En esta prueba técnica, utilizando TDD (Desarrollo Guiado por Pruebas) y siguiendo buenas prácticas de código, se solicita realizar el siguiente ejercicio.
        Se tiene una baldosería con una variedad de baldosas que pueden estar fabricadas con diferentes materiales y tener distintas formas (cuadrado, rectángulo, círculo). Los objetivos son los siguientes:
        Calcular el área total de una lista de baldosas. */
    [TestMethod]
    public void CrearBaldosa()
    {
        // Arrange
        var baldosa = new Baldosa();
        // Act
        // Assert
        Assert.IsNotNull(baldosa);
    }
    
    [TestMethod]
    public void CrearBaldosaConArea()
    {
        // Arrange
        var baldosa = new Baldosa(10);
        // Act
        // Assert
        Assert.IsNotNull(baldosa);
        Assert.AreEqual(10, baldosa.Area);
    }
    
    [TestMethod]
    public void CrearBaldosaConAreaYMaterialCeramica()
    {
        // Arrange
        var baldosa = new Baldosa(10, "ceramica");
        // Act
        // Assert
        Assert.IsNotNull(baldosa);
        Assert.AreEqual(10, baldosa.Area);
        Assert.AreEqual("ceramica", baldosa.Material);
    }

    [TestMethod]
    public void CrearBaldosaConAreaYMaterialPiedra()
    {
        // Arrange
        var baldosa = new Baldosa(10, "piedra");
        // Act
        // Assert
        Assert.IsNotNull(baldosa);
        Assert.AreEqual(10, baldosa.Area);
        Assert.AreEqual("piedra", baldosa.Material);
    }
    
    [TestMethod]
    public void CrearBaldosaConAreaMaterialYForma()
    {
        // Arrange
        var baldosa = new Baldosa(10, "ceramica", "cuadrado");
        // Act
        // Assert
        Assert.IsNotNull(baldosa);
        Assert.AreEqual(10, baldosa.Area);
        Assert.AreEqual("ceramica", baldosa.Material);
        Assert.AreEqual("cuadrado", baldosa.Forma);
    }

    [TestMethod]
    public void CalcularAreaBaldosa()
    {
        // Arrange
        var baldosa = new Baldosa(10, "ceramica", "cuadrado");
        // Act
        var area = baldosa.CalcularArea();
        // Assert
        Assert.AreEqual(100, area);
    }
    
    [TestMethod]
    public void CalcularAreaBaldosaRectangular()
    {
        // Arrange
        var baldosa = new Baldosa(10, "ceramica", "rectangular");
        // Act
        var area = baldosa.CalcularArea();
        // Assert
        Assert.AreEqual(100, area);
    }
    
    [TestMethod]
    public void CalcularAreaBaldosaCircular()
    {
        // Arrange
        var baldosa = new Baldosa(10, "ceramica", "circular");
        // Act
        var area = baldosa.CalcularArea();
        // Assert
        Assert.AreEqual(314.16, area, 0.01);
    }
}