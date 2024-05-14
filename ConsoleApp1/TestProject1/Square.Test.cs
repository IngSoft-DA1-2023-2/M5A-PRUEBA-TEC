using ConsoleApp1;

namespace TestProject1;

[TestClass]
public class SquareTest
{
    [TestMethod]
    public void ShouldCreateSquare()
    {
        Square square = new Square();

        Assert.IsNotNull(square);
    }

    [TestMethod]
    public void ShouldCreateSquareWithWidthHeightAndMaterial()
    {
        Material material = new Material("Wood", 100);
        Square square = new Square(10, 10, material);

        Assert.IsNotNull(square);
        Assert.AreEqual(10, square.Width);
        Assert.AreEqual(10, square.Height);
        Assert.AreEqual("Wood", square.Material.Name);
    }

    [TestMethod]
    public void ShouldGetSquareArea()
    {
        Material material = new Material("Wood", 100);
        Square square = new Square(10, 10, material);

        Assert.AreEqual(100, square.Area());
    }

    [TestMethod]
    public void ShouldGetSquarePrice()
    {
        Material material = new Material("Wood", 100);
        Square square = new Square(10, 10, material);

        Assert.AreEqual(10000, square.Price());
    }
}