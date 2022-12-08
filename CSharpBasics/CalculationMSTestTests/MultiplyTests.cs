using CSharpCalculator;
using System.Data;

namespace CalculationMSTestTests
{
    [TestClass]
    public class MultiplyTests
    {
        Calculator calculator = new Calculator();

        [DataTestMethod]
        [DataRow(2.5, 2.5, 6.25)]
        [DataRow(0, 7.55, 0)]
        [DataRow(-25, 10, -250)]
        public void Multiply_CorrectInputTest(double firstNumber, double secondNumber, double expectedresult)
        {
            var actualResult = calculator.Multiply(firstNumber, secondNumber);

            Assert.AreEqual(expectedresult, actualResult, $"Multiply action: Expected result {expectedresult} isn't equal {actualResult}");
        }
    }
}
