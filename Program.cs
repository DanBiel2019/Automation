namespace WebDriverDemo
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using System;

    //using OpenQA.Selenium.Chrome;

    public class Program
    {
        private static void Main(string[] args)
        {
            var webdriver = new FirefoxDriver();
            //var webdriver = new ChromeDriver();
            webdriver.Url = @"http://bing.com";

            var searchBox = webdriver.FindElement(By.Id("sb_form_q"));
            searchBox.SendKeys("butterfly");//This method inputs butterfly into the HTML's input element

            var searchButton = webdriver.FindElementById("sb_form_go");
            searchButton.Click();

            var firstResultLink = webdriver.FindElementByCssSelector("#b_results li.b_algo h2 a");
            firstResultLink.Click();
            var expectedUrl = "https://en.wikipedia.org/wiki/Butterfly";
            if (expectedUrl.Equals(webdriver.Url, System.StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}