using JobServeAutomation.JobServePages.PageObjects;
using OpenQA.Selenium;
using SeleniumTestPeoject.BrowserUlilities;

namespace SeleniumTestPeoject.JobServePages.JobServeHomePage
{
    public class JobServeHome : BrowserManager
    {
        private string keywords;
        private string jobPreference;
        private string locationPreference;

        private IWebElement KeyWordLocator => Driver.FindElement(By.Id("txtKey"));
        private IWebElement LocationLocator => Driver.FindElement(By.Id("txtLoc"));
        private IWebElement SearchButton => Driver.FindElement(By.Id("btnSearch"));
        private IWebElement JobTypeLocator => Driver.FindElement(By.CssSelector("select[class='shortdrop  searchDDNoJS TabIndexNoJS']"));

        public bool IsVisible 
        {
            get
            {
                var title = "IT Jobs, Engineering Jobs, Healthcare Jobs… Find your next job with JobServe";

                if (Driver.Title != null)
                {
                    return Driver.Title.Equals(title);
                }
                return false;      
            }

        }

        public JobServeHome SearchByKeyword(string value)
        {
            keywords = value;
            return this;
        }
        public JobServeHome JobType(string value)
        {
            jobPreference = value;          
            return this;
        }

        public JobServeHome Location(string value)
        {
            locationPreference = value;
            return this;
        }

        public void Search()
        {
            TextField.InputBox(KeyWordLocator, keywords);
            TextField.InputBox(LocationLocator, locationPreference);
            SelectFrom.SelectByVisibleText(JobTypeLocator, jobPreference.Trim());
            JobServeButtons.Submit(SearchButton);

        }


    }

    
}