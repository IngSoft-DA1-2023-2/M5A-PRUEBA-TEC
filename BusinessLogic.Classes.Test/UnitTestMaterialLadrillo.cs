namespace BusinessLogic.Classes.Test;

public class UnitTestMaterialLadrillo
{
    [TestMethod]
    public void TestConstructorMaterialLadrillo(){
        MaterialLadrillo material = new MaterialLadrillo();
        string nombreEsperado = "Ladrillo";
        int precioMetroCuadradoEsperado = 5;
        Assert.AreEqual(nombreEsperado,material.Nombre);
        Assert.AreEqual(precioMetroCuadradoEsperado,material.PrecioMetroCuadrado);
    }
}
