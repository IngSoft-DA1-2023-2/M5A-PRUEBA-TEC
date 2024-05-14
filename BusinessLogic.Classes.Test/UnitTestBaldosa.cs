namespace BusinessLogic.Classes.Test;

[TestClass]
public class UnitTestBaldosaCuadrada
{
    [TestMethod]
    public void TestConstructor()
    {   
        int lado = 2;
        Material material = new MaterialCeramica();
        BaldosaCuadrada baldosa = new BaldosaCuadrada(lado,material);
        Assert.AreEqual(baldosa.Ancho,lado);
        Assert.AreEqual(baldosa.Largo,lado);
        Assert.AreEqual(baldosa.Material.Nombre,material.Nombre); 
    }

    [TestMethod]
    public void TestCalcularArea(){
        int lado = 2;
        Material material = new MaterialCeramica();
        BaldosaCuadrada baldosa = new BaldosaCuadrada(lado,material);
        int areaEsperada = lado * lado;
        int areaCalculada = baldosa.CalcularArea();
        Assert.AreEqual(areaEsperada,areaCalculada);
    }

    [TestMethod]
    public void TestCalcularPrecio(){
        int lado = 2;
        Material material = new MaterialCeramica();
        BaldosaCuadrada baldosa = new BaldosaCuadrada(lado,material);
        int areaBaldosa = baldosa.CalcularArea();
        int precioMaterial = material.PrecioMetroCuadrado;
        int precioEsperado = areaBaldosa * precioMaterial;
        int precioCalculado = baldosa.CalcularPrecio();
        Assert.AreEqual(precioEsperado,precioCalculado);
    }
}