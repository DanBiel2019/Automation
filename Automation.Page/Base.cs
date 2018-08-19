using OpenQA.Selenium.Remote;

namespace Automation.Page
{
    public abstract class Base
    {
        internal readonly RemoteWebDriver WebDriver;

        protected Base(RemoteWebDriver webDriver) => WebDriver = webDriver;
    }
}