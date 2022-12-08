
using CSharpCalculator;

namespace CalculationNUnitTests
{
    [TestFixture]
    [Parallelizable]
    public class IsPisitiveTests
    {
        Calculator calculator = new Calculator();
        public const string WrongInput = "Wrong input";

        [TestCase(125)]
        [TestCase(0.17)]
        [TestCase("20")]
        public void IsPositive_PositiveInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.IsTrue(actualResult, $"Expected positive number but input {input} is negative or 0");
        }

        [TestCase(0)]
        [TestCase(-24)]
        [TestCase(-27.25)]
        [TestCase("-24,20")]
        public void IsPositive_NegativeInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.IsFalse(actualResult, $"Expected negative number but input {input} is positive");
        }

        [TestCase("twenty")]
        [TestCase("-24.25")]
        public void IsPositive_StringInputTest(object input)
        {
            Assert.Throws(typeof(NotFiniteNumberException), () => calculator.isPositive(input), $"{WrongInput}. Input {input} cannot convert to double");
        }
    }
}
