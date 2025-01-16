using System;
using EvaluationIntegrationContinue;

namespace EvaluationsIntegrationContinueTests
{

    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        [TestInitialize]

        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        //[TestMethod]
        //[DataRow(2, 4)]
        //[DataRow(3, 6)]
        //public void Subtract_FirstParameterIsTooLow_Test(int firstNumber, int secondNumber)
        //{
        //    var result = _mathOperations.Subtract(firstNumber, secondNumber);

        //    var exception = Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(firstNumber, secondNumber));
        //    Assert.AreEqual("Second parameter cannot be higher than first parameter", exception.Message);
        //}

        //[TestMethod]
        //[DataRow(1200, 4)]
        //[DataRow(9999, 6)]
        //public void Subtract_FirstParameterIsTooHigh_Test(int firstNumber, int secondNumber)
        //{
        //    var result = _mathOperations.Subtract(firstNumber, secondNumber);

        //    var exception = Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(firstNumber, secondNumber));
        //    Assert.AreEqual("First parameter cannot be higher or equal to 1200", exception.Message);
        //}

        [TestMethod]
        [DataRow(4, 2, 2)]
        [DataRow(12, 6, 6)]
        public void Subtract_FirstParameterAndSecondParameterIsCorrect_Test(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = _mathOperations.Subtract(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
