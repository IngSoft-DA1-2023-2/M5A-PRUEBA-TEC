namespace BusinessLogic.Classes.Test;
[TestClass]
public class UnitTestBaldosaRectangular
{
    [TestMethod]
    public void TestConstructorProperty()
    {   
        int largo = 2;
        int ancho = 3;
        Material material = new MaterialCeramica();
        BaldosaRectangular baldosa = new BaldosaRectangular(largo,ancho,material);
        Assert.AreEqual(baldosa.Ancho,ancho);
        Assert.AreEqual(baldosa.Largo,largo);
        Assert.AreEqual(baldosa.Material.Nombre,material.Nombre); 
    }

    [TestMethod]
    public void TestCalcularArea(){
        int largo = 2;
        int ancho = 3;
        Material material = new MaterialCeramica();
        BaldosaRectangular baldosa = new BaldosaRectangular(largo,ancho,material);
        int areaEsperada = largo * ancho;
        int areaCalculada = baldosa.CalcularArea();
        Assert.AreEqual(areaEsperada,areaCalculada);
    }

    [TestMethod]
    public void TestCalcularPrecio(){
        int largo = 2;
        int ancho = 3;
        Material material = new MaterialCeramica();
        BaldosaRectangular baldosa = new BaldosaRectangular(largo,ancho,material);
        int areaBaldosa = baldosa.CalcularArea();
        int precioMaterial = material.PrecioMetroCuadrado;
        int precioEsperado = areaBaldosa * precioMaterial;
        int precioCalculado = baldosa.CalcularPrecio();
        Assert.AreEqual(precioEsperado,precioCalculado);
    }
}
