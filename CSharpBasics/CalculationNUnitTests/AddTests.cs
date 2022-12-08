using CSharpCalculator;

namespace CalculationNUnitTests
{
    [TestFixture]
    public class AddTests
    {
        Calculator calculator = new Calculator();

        [Test]
        public void Add_WithCorrectInputTest()
        {
            var firstNumber = 20d;
            var secondNumber = 10d;
            var expectedresult = 30;

            var actualresult = calculator.Add(firstNumber, secondNumber);

            Assert.AreEqual(expectedresult, actualresult, $"Add action: Expected result {expectedresult} isn't equal {actualresult}");
        }
    }
}