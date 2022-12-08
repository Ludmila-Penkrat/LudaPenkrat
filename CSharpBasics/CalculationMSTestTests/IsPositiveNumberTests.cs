using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class IsPositiveNumberTests
    {
        Calculator calculator = new Calculator();
        public const string WrongInput = "Wrong input";

        [DataTestMethod]
        [DataRow(125)]
        [DataRow(0.17)]
        [DataRow("20")]
        public void IsPositive_PositiveInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.IsTrue(actualResult, $"Expected positive number but input {input} is negative or 0");
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-24)]
        [DataRow(-27.25)]
        [DataRow("-24,20")]
        public void IsPositive_NegativeInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.IsFalse(actualResult, $"Expected negative number but input {input} is positive");
        }

        [DataTestMethod]
        [DataRow("twenty")]
        [DataRow("-24.25")]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void IsPositive_StringInput_ExeptionTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.ThrowsException<NotFiniteNumberException>(() => actualResult, $"{WrongInput}. Input {input} cannot convert to double");
        }
    }
}