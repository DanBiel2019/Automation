using WebDriverDemo.Page;
using Xunit;

namespace WebDriverDemo.TestRunner
{
    public class SearchTest
    {
        [Theory]
        [InlineData(@"http://bing.com", "butterfly")]
        public void NavigateToWikiViaBing(string url, string searchParameter)
        {
            var webDriver = Healper.WebDriver(Driver.Firefox);
            webDriver.Navigate().GoToUrl(url);

            var homePage = new Home(webDriver);
            homePage.SearchTextBox.SendKeys(searchParameter);
            homePage.SearchButton.Click();

            var searchResult = new SearchResult(webDriver);
            searchResult.Item.Click();
            Assert.Equal("https://en.wikipedia.org/wiki/Butterfly", webDriver.Url);
        }
    }
}