using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class AddTests
    {
        Calculator calculator = new Calculator();
        
        [TestMethod]
        public void AddWithCorrectInputTest()
        {
            var firstNumber = 20d;
            var secondNumber = 10d;
            var expectedresult = 30;

            var actualresult = calculator.Add(firstNumber, secondNumber);

            Assert.AreEqual(expectedresult, actualresult, $"Add action: Expected result {expectedresult} isn't equal {actualresult}");
        }

        //[TestMethod]
        //[ExpectedException(typeof(InvalidCastException))]
        //public void AddWithWrongFormatInputExeption()
        //{
        //    var firstNumber = 20;
        //    var secondNumber = 10;
        //    var expectedresult = 30;
        //    calculator.Add(firstNumber, secondNumber));
        //}
     }
}