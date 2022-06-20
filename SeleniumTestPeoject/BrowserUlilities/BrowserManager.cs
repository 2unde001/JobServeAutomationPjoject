namespace SeleniumTestPeoject.BrowserUlilities
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using WebDriverManager;
    using WebDriverManager.DriverConfigs.Impl;
    
    public class BrowserManager
    {

        public BrowserManager()
        {

        }
        private static IWebDriver WebDriver { get; set; }
        private static readonly string URL;

        public static IWebDriver GetDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            WebDriver = new ChromeDriver();
            return WebDriver;
        }

        public static void LaunchBrowser()
        {
            GetDriver();
        }

        public static void Open()
        {
            WebDriver.Navigate().GoToUrl("https://jobserve.com/");
        }

        public static void Quit()
        {
            WebDriver.Close();
        }
    }
}