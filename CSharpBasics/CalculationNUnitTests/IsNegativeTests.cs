using CSharpCalculator;

namespace CalculationNUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class IsNegativeTests
    {
        Calculator calculator = new Calculator();
        public const string WrongInput = "Wrong input";

        [TestCase(-10)]
        [TestCase(-2.5)]
        [TestCase(0)]
        [TestCase("-125")]
        public void IsNegative_NegativInputTest(object input)
        {
            bool actualResult = calculator.isNegative(input);

            Assert.IsTrue(actualResult, $"Expected negative number but input number {input} is positive");
        }

        [TestCase(2)]
        [TestCase(100.25)]
        [TestCase("111")]
        [TestCase("12,25")]

        public void IsNegative_PositiveInputTest(object input)
        {
            bool actualResult = calculator.isNegative(input);

            Assert.IsFalse(actualResult, $"Expected positive number but input number {input} is negative or 0");
        }

        [TestCase("minus ten")]
        [TestCase("-12.55")]
        public void IsNegative_StringInputTest(object input)
        {
            Assert.Throws(typeof(NotFiniteNumberException), () => calculator.isNegative(input), $"{WrongInput}. Input {input} cannot convert to double");
        }
    }
}
