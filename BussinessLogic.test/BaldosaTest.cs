using BusinessLogic;

namespace BussinessLogic.test;

[TestClass]
public class BaldosaTest
{
    [TestMethod]
    public void calcularPrecio ()
    {
        Baldosa baldosa = new Baldosa(); 
        float expectedPrice = 0;
        float actualPrice = baldosa.calcularPrecio();
        Assert.AreEqual(expectedPrice,actualPrice);
    }
}