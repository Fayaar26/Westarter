

namespace Westarter
{
    public class Homepage
    {
        IWebDriver driver;
        public Homepage(IWebDriver go)
        {
                driver = go;


        }

        public IWebElement Element => driver.FindElements(By.ClassName("card mt-4 top-card")).ElementAt(0);

       public void ClickElement() => Element.Click();


    }

}
