using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test;

public class Shape_Test
{
    [TestMethod]
    public void ShouldCreateShape()
    {
        var shape = new Shape();
        Assert.IsNotNull(shape);
    }
}