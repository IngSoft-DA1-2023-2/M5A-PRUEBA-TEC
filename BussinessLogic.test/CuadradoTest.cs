using BusinessLogic;

namespace BussinessLogic.test;

[TestClass]
public class CuadradoTest
{
    [TestMethod]
    public void calcularAreaTest ()
    {   float largo = 10.0f;
    {   
        Cuadrada cuadrada = new Cuadrada(largo); 
        float expectedArea = 100.0f;
        float actualArea = cuadrada.calcularArea();
        Assert.AreEqual(expectedArea,actualArea);
    }
}}
