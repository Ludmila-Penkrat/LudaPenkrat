using CSharpCalculator;

namespace CalculationMSTestTests
{
    [TestClass]
    public class SubstructionTests
    {
        public const string WrongInput = "Wrong input";
        Calculator calculator = new Calculator();


        [TestMethod]
        public void Substruction_WithCorrectInputTest()
        {
            var firstNumber = 20;
            var secondNumber = 10;
            var expectedresult = 10;

            var actualResult = calculator.Sub(firstNumber, secondNumber);

            Assert.AreEqual(expectedresult, actualResult, $"Substruction action: Expected result {expectedresult} isn't equal {actualResult}");
        }

        [TestMethod]
        public void Substruction_WithDoubleDataTest()
        {
            var firstNumber = 1.4;
            var secondNumber = 1;
            var expectedresult = 0.4;

            var actualResult = Math.Round(calculator.Sub(firstNumber, secondNumber), 2, MidpointRounding.AwayFromZero);

            Assert.AreEqual(expectedresult, actualResult, $"Substruction action: Expected result {expectedresult} isn't equal {actualResult}");
        }

        [TestMethod]
        public void Substruction_WithStringDataTest()
        {
            var firstNumber = "twenty";
            var secondNumber = "ten";
            
            try
            {
                calculator.Sub(firstNumber, secondNumber);
            }
            catch (NotFiniteNumberException ex)
            {
                StringAssert.Contains(ex.Message, WrongInput);
            }
            //Assert.ThrowsException<NotFiniteNumberException>(() => calculator.Sub(firstNumber, secondNumber), WrongInput);
        }
    }
}
