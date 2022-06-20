using OpenQA.Selenium;

namespace JobServeAutomation.JobServePages.PageObjects
{
    public class TextField
    {

        public static void InputBox(IWebElement textFiledLocator, string text)
        {
            textFiledLocator.Clear();
            textFiledLocator.SendKeys(text);
        }
    }
}