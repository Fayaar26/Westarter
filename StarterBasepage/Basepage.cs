using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Westarter.Pages;

namespace Westarter
{
    public class BasePage
    {
        public IWebDriver browser;

        [SetUp]
        public void Setup()
        {
            
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(Utilities.Link.Demoqua);
        }

        [Test]
        public void Test1()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)browser;
            js.ExecuteScript("window.scrollBy(0, 250)");
            HomePage homePage = new HomePage(browser);
            homePage.ClickElements();
        }


        [TearDown]
        public void TearDown() 
        { 
            Thread.Sleep(3000);
            browser.Quit();
        }
    }

}
