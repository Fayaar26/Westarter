using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Westarter.Pages
{
    public class HomePage
    {
        public IWebDriver browser;

        public HomePage(IWebDriver go)
        {
            browser = go;
        }

        IWebElement elements =>
            browser.FindElement(By.XPath("//div[@class='card mt-4 top-card'][.='Elements']"));


        public void ClickElements()=> elements.Click();

    }
}
