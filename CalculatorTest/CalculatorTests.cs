using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void StringToFormulaTests()
        {
            string[] initialArray = { "1+2*3", "(1-2*3)+5","1/0","0091837,1344'FSD"};
            string[] resultArray = new string[initialArray.Length];

            for(int i = 0; i<initialArray.Length; i++)
            {
                resultArray[i] = StringToFormulaAdapter.CheckAnswerOf(initialArray[i]);
            }

            Assert.AreEqual("7", resultArray[0]);
            Assert.AreEqual("0", resultArray[1]);
            Assert.AreEqual(" ÎØÈÁÊÀ ", resultArray[2]);
            Assert.AreEqual(" ÎØÈÁÊÀ ", resultArray[3]);
        }
    }
}
