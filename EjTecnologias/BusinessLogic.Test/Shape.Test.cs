using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test;

[TestClass]

public class ShapeTest
{
    [TestMethod]
    public void ShouldCreateShape()
    {
        var shape = new Shape();
        Assert.IsNotNull(shape);
    }
}