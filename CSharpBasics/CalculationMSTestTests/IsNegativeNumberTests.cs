using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class IsNegativeNumberTests
    {
        Calculator calculator = new Calculator();

        [DataTestMethod]
        [DataRow(-10)]
        [DataRow(-2.5)]
        [DataRow(0)]
        [DataRow("-125")]
        public void IsNegativeNegativInputTest(object input)
        {
            bool actualResult = calculator.isNegative(input);

            Assert.IsTrue(actualResult, $"Expected negative number but input number {input} is positive");
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(100.25)]
        [DataRow("111")]
        [DataRow("12,25")]
        public void IsNegativePositiveInputTest(object input)
        {
            bool actualResult = calculator.isNegative(input);

            Assert.IsFalse(actualResult, $"Expected positive number but input number {input} is negative or 0");
        }

        [DataTestMethod]
        [DataRow("minus ten")]
        [DataRow("-12.55")]
        [DataRow(" ")]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void IsNegativeStringInputExeptionTest(object input)
        {
            var actualResult = calculator.isNegative(input);
        }
    }
}
