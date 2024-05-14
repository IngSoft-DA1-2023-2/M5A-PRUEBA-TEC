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
    
    
    [TestMethod]
    public void ShouldSetSquareSide()
    {
        var square = new Square();
        square.Side = 5;
        Assert.AreEqual(5, square.Side);
    }
}