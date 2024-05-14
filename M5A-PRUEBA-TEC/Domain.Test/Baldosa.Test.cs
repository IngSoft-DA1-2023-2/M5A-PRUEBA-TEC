using Domain.Enums;

namespace Domain.Test;

[TestClass]
public class BaldosaTest
{
    [TestMethod]
    public void TestCalculateArea()
    {
        var baldosa = new Baldosa(Material.Ceramica, FormaFormaEnum.Circle, 1);
        var result = baldosa.CalculateArea();
        Assert.AreEqual(Math.PI, result); 
    }

    [TestMethod]
    public void TestGetCostoPorBaldosa()
    {
        var baldosa = new Baldosa(Material.Ceramica, FormaFormaEnum.Square, 1);
        var result = baldosa.GetCostoPorBaldosa();
        Assert.AreEqual(10, result);
    }
}
