using Automation.Page;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using Xunit;

namespace Automation.Runner
{
    public class SearchBingTest : IDisposable
    {
        private readonly RemoteWebDriver _webDriver;

        public SearchBingTest()
        {
            _webDriver = new FirefoxDriver(AppDomain.CurrentDomain.BaseDirectory);
            _webDriver.Navigate().GoToUrl(@"http://bing.com");
        }

        [Theory]
        [InlineData("butterfly", @"https://en.wikipedia.org/wiki/Butterfly")]
        [InlineData("cucumber", @"https://cucumber.io/")]
        public void NavigateToWikiViaBing(string searchParameter, string assertUrl)
        {
            var homePage = new Home(_webDriver);
            homePage.Search(searchParameter);

            var searchResult = new SearchResult(_webDriver);
            searchResult.ClickFirstItem();
            Assert.Equal(assertUrl, _webDriver.Url);
        }

        public void Dispose()
        {
            _webDriver.Close();
        }
    }
}