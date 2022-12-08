using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class IsNegativeNumberTests
    {
        Calculator calculator = new Calculator();
        public const string WrongInput = "Wrong input";

        [DataTestMethod]
        [DataRow(-10)]
        [DataRow(-2.5)]
        [DataRow(0)]
        [DataRow("-125")]
        public void IsNegative_NegativInputTest(object input)
        {
            bool actualResult = calculator.isNegative(input);

            Assert.IsTrue(actualResult, $"Expected negative number but input number {input} is positive");
        }

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(100.25)]
        [DataRow("111")]
        [DataRow("12,25")]

        public void IsNegative_PositiveInputTest(object input)
        {
            bool actualResult = calculator.isNegative(input);

            Assert.IsFalse(actualResult, $"Expected positive number but input number {input} is negative or 0");
        }

        [DataTestMethod]
        [DataRow("minus ten")]
        [DataRow("-12.55")]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void IsNegative_StringInput_ExeptionTest(object input)
        {
            var actualResult = calculator.isNegative(input);

            Assert.ThrowsException<NotFiniteNumberException>(() => actualResult, $"{WrongInput}. Input {input} cannot convert to double");
        }
    }
}
