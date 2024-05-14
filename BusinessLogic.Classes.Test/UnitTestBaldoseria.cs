namespace BusinessLogic.Classes.Test;
[TestClass]
public class UnitTestBaldoseria
{
    [TestMethod]
    public void TestConstructor(){
        Baldoseria baldoseria = new Baldoseria();
        Assert.IsNotNull(baldoseria);
    }

    [TestMethod]
    public void TestAgregarBaldosa(){
        Baldoseria baldoseria = new Baldoseria();
        Material material = new MaterialCeramica();
        int lado = 2;
        Baldosa baldosa = new BaldosaCuadrada(lado,material);
        baldoseria.AgregarBaldosa(baldosa);
        Assert.AreEqual(baldoseria.Baldosas.First(),baldosa);
    }

    [TestMethod]
    public void TestEliminarBaldosa(){
        Baldoseria baldoseria = new Baldoseria();
        Material material = new MaterialCeramica();
        int lado = 2;
        int largoEsperado = 0;
        Baldosa baldosa = new BaldosaCuadrada(lado,material);
        baldoseria.AgregarBaldosa(baldosa);
        baldoseria.RemoverBaldosa(baldosa);
        Assert.AreEqual(largoEsperado,baldoseria.Baldosas.Count);
    }

    [TestMethod]
    public void TestCalcularAreaTotal(){
        Baldoseria baldoseria = new Baldoseria();
        Material material = new MaterialCeramica();
        int lado = 2;
        Baldosa baldosa = new BaldosaCuadrada(lado,material);
        int areaTotalEsperada = baldosa.CalcularArea() + baldosa.CalcularArea();
        baldoseria.AgregarBaldosa(baldosa);
        baldoseria.AgregarBaldosa(baldosa);
        int areaTotalObtenida = baldoseria.CalcularAreaTotal();
        Assert.AreEqual(areaTotalObtenida,areaTotalEsperada);
    }

    [TestMethod]
    public void TestCalcularPrecioTotal(){
        Baldoseria baldoseria = new Baldoseria();
        Material material = new MaterialCeramica();
        int lado = 2;
        Baldosa baldosa = new BaldosaCuadrada(lado,material);
        int precioTotalEsperado = baldosa.CalcularPrecio() + baldosa.CalcularPrecio();
        baldoseria.AgregarBaldosa(baldosa);
        baldoseria.AgregarBaldosa(baldosa);
        int precioTotalObtenido = baldoseria.CalcularPrecioTotal();
        Assert.AreEqual(precioTotalObtenido,precioTotalEsperado);
    }
}
