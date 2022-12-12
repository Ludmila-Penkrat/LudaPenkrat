using CSharpCalculator;

namespace CalculationXUnitTests
{
    public class AddTests
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void AddWithCorrectInputTest()
        {
            var firstNumber = 20.256;
            var secondNumber = 10.244;
            var expectedresult = 30.5;

            var actualresult = calculator.Add(firstNumber, secondNumber);
            Assert.Equal(expectedresult, actualresult);
        }
    }
}
