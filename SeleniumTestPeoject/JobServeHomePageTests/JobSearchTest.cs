
using SeleniumTestPeoject.Hook;
using SeleniumTestPeoject.JobServePages.JobServeHomePage;

namespace SeleniumTestPeoject.JobServeHomePage
{
    [TestClass]
    public class JobSearchTest : Hooks
    {
        JobServeHome jobServeHome = new JobServeHome();
        JobServeResults jobServeResults = new JobServeResults();


        [TestMethod]
        public void ShouldSaerchForJob() 
        {
            jobServeHome.SearchByKeyword("Selenium")
                .Location("London").JobType("Contract/Permanent").Search();
            Assert.IsTrue(jobServeResults.isAt());
            
        }
    }
}
