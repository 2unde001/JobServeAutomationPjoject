namespace SeleniumTestPeoject.BrowserUlilities
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using WebDriverManager;
    using WebDriverManager.DriverConfigs.Impl;

    public class BrowserManager
    {

        protected static IWebDriver Driver { get; private set; }
        private static readonly string URL;

        public static IWebDriver GetDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver();
            return Driver;
        }

        public static void LaunchBrowser()
        {
            GetDriver();
        }

        public static void Open()
        {
            GetDriver();
            Driver.Navigate().GoToUrl("https://jobserve.com/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);


        }

        public static void Quit()
        {
            Driver.Close();
        }
    }
}