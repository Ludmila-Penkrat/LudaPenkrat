
using CSharpCalculator;

namespace CalculationNUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class MultiplyTests
    {
        Calculator calculator;

        [SetUp]
        public void InitializeCalc()
        {
            calculator = new Calculator();
        }
        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test finished");
        }

        [TestCase(2.5, 2.5, 6.25)]
        [TestCase(0, 7.55, 0)]
        [TestCase(-25, 10, -250)]
        public void Multiply_WithCorrectInputTest(double firstNumber, double secondNumber, double expectedresult)
        {
            var actualResult = calculator.Multiply(firstNumber, secondNumber);

            Assert.AreEqual(expectedresult, actualResult, $"Multiply action: Expected result {expectedresult} isn't equal {actualResult}");
        }
    }
}
