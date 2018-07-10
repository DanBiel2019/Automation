using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WebDriverDemo.TestRunner
{
    public static class Healper
    {
        public static IWebDriver WebDriver(Driver driver = Driver.Firefox, string url = null)
        {
            IWebDriver webDriver = null;
            switch (driver)
            {
                case Driver.Firefox:
                    webDriver = new FirefoxDriver();
                    break;

                case Driver.Chrome:
                    webDriver = new ChromeDriver();
                    break;
            }
            if (webDriver != null && !string.IsNullOrEmpty(url))
            {
                webDriver.Url = url;
            }
            return webDriver;
        }
    }
}