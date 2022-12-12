using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class IsPositiveNumberTests
    {
        Calculator calculator = new Calculator();

        [DataTestMethod]
        [DataRow(125)]
        [DataRow(0.17)]
        [DataRow("20")]
        public void IsPositivePositiveInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.IsTrue(actualResult, $"Expected positive number but input {input} is negative or 0");
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-24)]
        [DataRow(-27.25)]
        [DataRow("-24,20")]
        public void IsPositiveNegativeInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.IsFalse(actualResult, $"Expected negative number but input {input} is positive");
        }

        [DataTestMethod]
        [DataRow("twenty")]
        [DataRow("-24.25")]
        [DataRow(" ")]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void IsPositiveStringInput_ExeptionTest(object input)
        {
            var actualResult = calculator.isPositive(input);
        }
    }
}