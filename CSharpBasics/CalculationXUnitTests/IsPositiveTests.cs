
using CSharpCalculator;

namespace CalculationXUnitTests
{
    public class IsPositiveTests
    {
        Calculator calculator = new Calculator();

        [Theory]
        [InlineData(125)]
        [InlineData(0.17)]
        [InlineData("2")]
        public void IsPositiveWithPositiveInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.True(actualResult, $"Expected positive number but input {input} is negative or 0");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-24)]
        [InlineData(-27.25)]
        [InlineData("-24,20")]

        public void IsPositiveWithNegativeInputTest(object input)
        {
            var actualResult = calculator.isPositive(input);

            Assert.False(actualResult, $"Expected negative number but input {input} is positive");
        }

        [Theory]
        [InlineData("twenty")]
        [InlineData("-27.25")]
        [InlineData(" ")]

        public void IsPositivWithStringInputException(object input)
        {
            try
            {
                calculator.isPositive(input);
            }
            catch(NotFiniteNumberException ex)
            {
                Console.WriteLine($"{ex.Message}. Input {input} cannot convert to double");
            }
        }

        [Theory]
        [InlineData("twenty")]
        [InlineData("-27.25")]
        [InlineData(" ")]

        public void IsPositivWithInvalidInputWrongInputExseption(object input)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.isPositive(input));
        }
    }
}