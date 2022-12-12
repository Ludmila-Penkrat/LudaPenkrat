

using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class DivideTests
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        public void DivideWithCorrectInputTest()
        {
            var firstNumber = 20.5;
            var secondNumber = 10.2;
            var expectedresult = 2.01;

            var actualResult = calculator.Divide(firstNumber, secondNumber);

            Assert.AreEqual(expectedresult, actualResult, delta: 0.01, $"Divide action: Expected result {expectedresult} isn't equal {actualResult}");
        }

        [TestMethod]
        public void DividePositiveInputByZeroTest()
        {
            var firstNumber = 20.5;
            var secondNumber = 0;

            var actualResult = calculator.Divide(firstNumber, secondNumber);

            Assert.IsTrue(double.IsPositiveInfinity(actualResult), $"The expected result \"Infinity\" of division double number by zero is not equal {actualResult}");
        }

        [TestMethod]
        public void DivideNegativeInputByZeroTest()
        {
            var firstNumber = -100;
            var secondNumber = 0;

            var actualResult = calculator.Divide(firstNumber, secondNumber);

            Assert.IsTrue(double.IsNegativeInfinity(actualResult), $"The expected result \"Infinity\" of division double number by zero is not equal {actualResult}");
        }

        [TestMethod]
        public void DivideDoubleZeroByDoubleZeroTest()
        {
            var firstNumber = 0.0;
            var secondNumber = 0.0;

            var actualResult = calculator.Divide(firstNumber, secondNumber);

            Assert.IsTrue(double.IsNaN(actualResult), $"The expected result \"NaN\" of division be zero of double number is not equal {actualResult}");
        }
    }           
}
