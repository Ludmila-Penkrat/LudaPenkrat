using CSharpCalculator;

namespace CalculationNUnitTests
{
    [TestFixture]
    public class AddTests
    {
        Calculator calculator = new Calculator();

        [Test]
        public void AddWithCorrectInputTest()
        {
            var firstNumber = 20d;
            var secondNumber = 10d;
            var expectedresult = 30;

            var actualresult = calculator.Add(firstNumber, secondNumber);

            Assert.That(actualresult, Is.EqualTo(expectedresult), $"Add action: Expected result {expectedresult} isn't equal {actualresult}");
        }
    }
}