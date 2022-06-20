namespace UnitTestCoreProject
{
    [TestClass]
    public class TestFeature

    {
        [TestMethod]
        [TestCategory("First Test")]
        [Description("Testing add operator")]
        public void TestMethod1()
        {
            var a = 6;
            var b = 4;
            Assert.AreEqual(10, a + b);
        }

        [TestMethod]
        public void ShouldBeTrue()
        {
            var i = 1;
            Assert.IsTrue(i == 1);
        }

        [TestMethod]
        public void ShouldNotEqual() 
        {
            var a = 4;
            var b = 5;
            Assert.AreNotEqual(a, b);
        }


    }

}