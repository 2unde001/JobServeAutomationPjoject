using SeleniumTestPeoject.BrowserUlilities;

namespace SeleniumTestPeoject.Hook
{
    [TestClass]
    public class Hooks
    {

        [TestInitialize]
        public void setup()
        {

            BrowserManager.Open();

        }

        [TestCleanup]
        public void CloseBrowser()
        {
            BrowserManager.Quit();
        }
    }
}