using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test;

[TestClass]
public class Circle_Test
{
    [TestMethod]
    public void ShouldCreateNewCircleShape()
    {
        var circle = new Circle();
        Assert.IsNotNull(circle);
    }
    
    [TestMethod]
    public void ShouldCalculateCircleArea()
    {
        var circle = new Circle();
        circle.Radius = 5;
        Assert.AreEqual(78, circle.Area());
    }


}