using OpenQA.Selenium;

namespace JobServeAutomation.JobServePages.PageObjects
{
    public class JobServeButtons
    {
        public static void Submit(IWebElement searchButton)
        {
            searchButton.Click();
        }
    }
}