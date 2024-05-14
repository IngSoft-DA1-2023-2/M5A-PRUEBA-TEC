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


}