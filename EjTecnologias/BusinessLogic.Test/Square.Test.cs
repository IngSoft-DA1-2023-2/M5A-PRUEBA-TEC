using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.Test;

[TestClass]
public class Square_Test
{
    [TestMethod]
    public void ShouldCreateNewSquareShape()
    {
        var square = new Square();
        Assert.IsNotNull(square);
    }
}