using OpenQA.Selenium;
using SeleniumTestPeoject.BrowserUlilities;

namespace SeleniumTestPeoject.JobServeHomePage
{
    public class JobServeResults: BrowserManager
    {
        private IWebElement ResultCount => Driver.FindElement(By.CssSelector("span[class='resultnumber']"));
        public bool isAt()
        {
            if (int.Parse(ResultCount.Text) > 0)
            {
                return true;
            }
            return false;
            
        }
    }
}