using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Westarter
{
    public class Tests
    {
        public IWebDriver browser;
        [SetUp]
        public void Setup()
        {
            
           ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximize");
            IWebDriver browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(Utilities.Link.Demoqua);


        }

        [Test]
        public void Test1()
        {
            
            Homepage homepage= new Homepage(browser);
            homepage.ClickElement();




        }




        [TearDown]
        public void TearDown() 
        { 
        
        
        
        
        }

    }

}
