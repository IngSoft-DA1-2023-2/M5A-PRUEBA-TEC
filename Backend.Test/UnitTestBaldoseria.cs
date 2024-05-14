namespace Backend.Test;

[TestClass]
public class UnitTestBaldoseria
{
    [TestMethod]
    public void TestCrearBaldoseria()
    {
        var baldosa = new Baldoseria();
        Assert.IsNotNull(baldosa);
    }

    [TestMethod]
    public void TestAgregarBaldosa()
    {
        var baldoseria = new Baldoseria();
        var baldosa1 = new BaldosaCuadrada();
        baldosa1.largo = 2;
        baldosa1.ancho = 2;
        baldosa1.Material = "Porcelana";
        baldoseria.AgregarBaldosa(baldosa1);
        Assert.AreEqual(1,baldoseria.baldosas.Length());
    }

    
    [TestMethod]
    public void TestCalcularAreaListaBaldosas()
    {
        var baldoseria = new Baldoseria();
        var baldosa1 = new BaldosaCuadrada();
        baldosa1.largo = 2;
        baldosa1.ancho = 2;
        baldosa1.Material = "Porcelana";
        var baldosa2 = new BaldosaRectangular();
        baldosa2.largo = 2;
        baldosa2.ancho = 3;
        baldosa2.Material = "Tierra";
        baldoseria.AgregarBaldosa(baldosa1);
        baldoseria.AgregarBaldosa(baldosa2);
        var resultadoEsperado = 10;
        var resultado = baldoseria.calcularAreaTotal();
        Assert.AreEqual(resultado,resultadoEsperado);
    }

}