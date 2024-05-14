namespace BusinessLogic.Classes.Test;
[TestClass]
public class UnitTestMaterialCeramica
{
    [TestMethod]
    public void TestConstructorMaterialCeramica(){
        MaterialCeramica material = new MaterialCeramica();
        string nombreEsperado = "Cerámica";
        int precioMetroCuadradoEsperado = 1;
        Assert.AreEqual(nombreEsperado,material.Nombre);
        Assert.AreEqual(precioMetroCuadradoEsperado,material.PrecioMetroCuadrado);
    }
}
