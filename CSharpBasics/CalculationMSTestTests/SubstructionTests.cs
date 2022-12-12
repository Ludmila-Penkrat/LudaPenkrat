using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class SubstructionTests
    {
        public const string WrongInput = "Wrong input";
        Calculator calculator = new Calculator();


        [TestMethod]
        public void SubstructionWithCorrectInputTest()
        {
            var firstNumber = 20;
            var secondNumber = 10;
            var expectedresult = 10;

            var actualResult = calculator.Sub(firstNumber, secondNumber);

            Assert.AreEqual(expectedresult, actualResult, $"Substruction action: Expected result {expectedresult} isn't equal {actualResult}");
        }

        [TestMethod]
        public void SubstructionWithDoubleDataTest()
        {
            var firstNumber = 1.4;
            var secondNumber = 1;
            var expectedresult = 0.4;

            var actualResult = Math.Round(calculator.Sub(firstNumber, secondNumber), 2, MidpointRounding.AwayFromZero);

            Assert.AreEqual(expectedresult, actualResult, $"Substruction action: Expected result {expectedresult} isn't equal {actualResult}");
        }

        [TestMethod]
        [DataRow("twenty", "ten")]
        [DataRow(" ", " ")]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void SubstructionWithStringDataTest(string firstValue, string secondValue)
        {           
            calculator.Sub(firstValue, secondValue);
        }

        [TestMethod]
        [DataRow("twenty", "ten")]
        [DataRow(" ", " ")]
        public void SubstructionWithStringDataTest1(string firstValue, string secondValue)
        {
            try
            {
                calculator.Sub(firstValue, secondValue);
            }
            catch (NotFiniteNumberException ex)
            {
                StringAssert.Contains(ex.Message, WrongInput);
            }
            //Assert.ThrowsException<NotFiniteNumberException>(() => calculator.Sub(firstNumber, secondNumber), WrongInput);
        }
    }
}
