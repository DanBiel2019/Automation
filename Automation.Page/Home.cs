using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Automation.Page
{
    public class Home : Base
    {
        public Home(RemoteWebDriver webDriver) : base(webDriver)
        {
        }

        public IWebElement SearchTextBox => WebDriver.FindElementById("sb_form_q");

        public IWebElement SearchButton => WebDriver.FindElementById("sb_form_go");

        public void Search(string parameter)
        {
            SearchTextBox.SendKeys(parameter);
            SearchButton.Click();
        }
    }
}