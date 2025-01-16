using EvaluationSampleCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluationSampleCode.Tests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(100, 50, 50)]
        [DataRow(20, 10, 10)]
        public void Subtract_ValidInputs_ReturnsCorrectResult(int numberOne, int numberTwo, int expectedResult)
        {
       
            var mathOps = new MathOperations();

        
            var result = mathOps.Subtract(numberOne, numberTwo);

    
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(1, "Blue")]
        [DataRow(2, "Red")]
        [DataRow(3, "Blue")]
        public void GetColorFromOddsNumber_ValidInputs_ReturnsCorrectColor(int number, string expectedColor)
        {
       
            var mathOps = new MathOperations();

        
            var result = mathOps.GetColorFromOddsNumber(number);

       
            Assert.AreEqual(expectedColor, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Subtract_SecondParameterHigher_ThrowsException()
        {
       
            var mathOps = new MathOperations();

       
            mathOps.Subtract(10, 20);
        }
    }
}
