using BusinessLogic;

namespace BussinessLogic.test;

[TestClass]
public class RectangularTest
{
    [TestMethod]
    public void calcularArea ()
    {   float ancho = 10.0f;
    {   float largo = 15.0f;
        Rectangular rectangular = new Rectangular(largo, ancho ); 
        float expectedArea = 150.0f;
        float actualArea = rectangular.calcularArea();
        Assert.AreEqual(expectedArea,actualArea);
    }
}}
