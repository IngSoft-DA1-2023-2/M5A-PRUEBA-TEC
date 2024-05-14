using Domain.Enums;


namespace Domain.Test
{
    [TestClass]
    public class CalculatorBaldosasTest
    {
        [TestMethod]
        public void TestCalculateTotalArea()
        {
            var calculator = new CalculatorBaldosas();
            calculator.AddBaldosa(new Baldosa(Material.Ceramica, FormaFormaEnum.Circle, 1));
            calculator.AddBaldosa(new Baldosa(Material.Ceramica, FormaFormaEnum.Square, 1));

            var result = calculator.CalculateTotalArea();
            Assert.AreEqual(Math.PI + 1, result);
        }

        [TestMethod]
        public void TestCalculateTotalCosto()
        {
            var calculator = new CalculatorBaldosas();
            calculator.AddBaldosa(new Baldosa(Material.Ceramica, FormaFormaEnum.Circle, 1));
            calculator.AddBaldosa(new Baldosa(Material.Ceramica, FormaFormaEnum.Square, 1));

            var result = calculator.CalculateTotalCosto();
            Assert.AreEqual(10 * (Math.PI + 1), result);
        }
    }
}