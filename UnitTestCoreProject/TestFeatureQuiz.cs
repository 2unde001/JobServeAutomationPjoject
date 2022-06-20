using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCoreProject
{
    [TestClass]

    public class TestFeatureQuiz
    {
        [TestMethod]
        [TestCategory("Quiz")]

        public void CheckTwoNumbersAreEqual() 
        {
            int a= 4;
            int b = 5;
            var expected = a + b;
            var actual = 9;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Quiz")]
        public void ShouldFail() 
        {
            string name = "Tunde";
            string expected = name;

            Assert.Fail("Not my name", expected);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void FailedTest()
        {
            int x = 9;
            int y = 11;
            var expected = x + y;

            Assert.AreNotEqual(20, expected);
        }
    }
}
