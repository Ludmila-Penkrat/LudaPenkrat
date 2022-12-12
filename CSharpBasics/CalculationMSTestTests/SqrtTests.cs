using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class SqrtTests
    {
        Calculator calculator = new Calculator();

        [DataTestMethod]
        [DataRow (25, 5)]
        [DataRow (6.25, 2.5)]
        [DataRow (1_000_000, 1_000)]
        public void SqrtWithCorrectInputTest(object input, double expectedResult)
        {

            var actualResult = calculator.Sqrt(input);

            Assert.AreEqual(expectedResult, actualResult, delta: 0.1, $"Sqrt action: Expected result {expectedResult} isn't equal {actualResult}");
        }

        [TestMethod]
        public void SqrtWithNegativInputWithoutExceptionTest()
        {
            var firstNumber = -25;
            
            var actualResult = calculator.Sqrt(firstNumber);

            Assert.IsTrue(Double.IsNaN(actualResult), $"The expected result \"NaN\" of getting the square root from negative number is not equal {actualResult}");
        }

        //This test is performed if such kind of exception would be handled in code
        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void SqrtWithNegativInputExceptionTest()
        //{
        //    var firstNumber = -25;

        //    Assert.ThrowsException<Exception>(() => calculator.Sqrt(firstNumber), "Get square root from negative number is impossible");
        //} 
    }
}
