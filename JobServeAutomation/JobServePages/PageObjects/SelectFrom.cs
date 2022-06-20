using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace JobServeAutomation.JobServePages.PageObjects
{
    public class SelectFrom
    {
        public static void SelectByVisibleText(IWebElement jobTypeLocator, string jobOption)
        {
            SelectElement select = new SelectElement(jobTypeLocator);
            select.SelectByText(jobOption);
        }
    }
}