using System.Diagnostics;

namespace UnitTestCoreProject
{
    [TestClass]
    public class TestFeatureInitialize
    {
        int a;
        private TestContext _testContext;

        /// <summary>
        /// TestInitialize attribute would always 
        /// start before each of the test execution
        /// </summary>
        [TestInitialize] // Second execution
        public void RunBeforeEveryTest() 
        {
            a = 3;
        }

        [TestCleanup] // Last execution
        [Description("Clean up each test after test execution")]
        public void ShouldRunAfterEveryTestMothod()
        {
            Trace.Write("This method should execute after every single test method in a class");
        }

        [ClassInitialize] // First execution
        public void ShouldRunBeforeAllTheTestMethodsStarted(TestContext testContext) 
        {
            _testContext = testContext;
            Trace.Write("I will run one time before all the test in the class started");
        }

        [ClassCleanup]// Run last
        public void RunAfterEveryTestClass() 
        {
            Trace.Write("I should run one time after all the tests in the class finishes");
        } 

        [TestMethod]
        public void CheckTwoNumbersAreEqual()
        {
            int b = 5;
            var expected = a + b;
            var actual = 8;

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
            int y = 11;
            var expected = a + y;

            Assert.AreNotEqual(14, expected);
        }

    }
}
