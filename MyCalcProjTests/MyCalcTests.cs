using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcProj;

namespace MyCalcProjTests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void ValidateAdditionTest()
        {
            var addClass = new AddClass();
            var result = addClass.AddTwoVariables(4, 5);
            Assert.AreEqual(4 + 5, result);
        }

        [TestMethod]
        public void ValidateMutiplyTest()
        {
            var multiplyClass = new MultiplyClass();
            var result = multiplyClass.MultiplyTwoVariables(4, 5);
            Assert.AreEqual(4 * 5, result);

        }
    }
}