using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Automation.Page
{
    public class SearchResult : Base
    {
        public SearchResult(RemoteWebDriver webDriver) : base(webDriver)
        {
        }

        public IWebElement Item => WebDriver.FindElementByCssSelector("#b_results li.b_algo h2 a");

        public void ClickFirstItem()
        {
            Item.Click();
        }
    }
}