using Baldosas;

namespace baldosas.tests;

[TestClass]
public class UnitTest1
{
    private string _nombreMaterial = "ceramica";
    private int _precioMaterial = 10;
    
    [TestMethod]
    public void Material_ShouldConstruct()
    {
        var material = new Material(_nombreMaterial, _precioMaterial);
        Assert.AreEqual(_nombreMaterial, material.Nombre);
        Assert.AreEqual(_precioMaterial, material.Precio);
    }
    
    [TestMethod]
    public void BaldosaCuadrada_ShouldCalculateArea()
    {
        var lado = 5;
        var baldosa = new BaldosaCuadrada { Lado = lado };
        Assert.AreEqual(lado * lado, baldosa.Area());
    }

    [TestMethod]
    public void BaldosaCuadrada_ShouldConstruct()
    {
        var baldosacuadrada = new BaldosaCuadrada();
        baldosacuadrada.Lado = 5;
        Assert.AreEqual(5, baldosacuadrada.Lado);
    }

    [TestMethod]
    public void BaldosaTriangular_ShouldConstruct()
    {
        var baldosatriangular = new BaldosaTriangular();
        baldosatriangular.Base = 5;
        baldosatriangular.Altura = 10;
        Assert.AreEqual(5, baldosatriangular.Base);
        Assert.AreEqual(10, baldosatriangular.Altura);
    }
    
    [TestMethod]
    public void BaldosaTriangular_ShouldCalculateArea()
    {
        var baseTriangular = 5;
        var alturaTriangular = 10;
        var baldosa = new BaldosaTriangular { Base = baseTriangular, Altura = alturaTriangular };
        Assert.AreEqual((baseTriangular * alturaTriangular) / 2, baldosa.Area());
    }
}