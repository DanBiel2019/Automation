# Selenium WebDriver Demo
This repository contains sample code for implementing Automation for Selenium's WebDriver.

## What does the Sample/Demo code do?
* Opens the Firefox Browser
* Navigates to http://bing.com
* Finds the search box by using FindElementById(“sb_form_q”)
* Fills in the identified text butterfly in the search box
* Finds the search button using FindElementById(“sb_form_go”)
* Clicks on the identified search button. So the bing will return the search results.
* Finds the first item from the search results using * FindElementByCssSelector(“#b_results li.b_algo h2 a”)
* Clicks on the identified first item and navigates to the first link

## NuGet Packages used

* [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver)
* [Selenium.Firefox.WebDriver](https://www.nuget.org/packages/Selenium.Firefox.WebDriver/)
* [Selenium.Chrome.WebDriver](https://www.nuget.org/packages/Selenium.Chrome.WebDriver/)

### Selenium.Firefox.WebDriver
This packages contains driver for GECKO and it gets copied to the Run or Debug directory

### Selenium.Chrome.WebDriver
This packages contains driver for CHROME and it gets copied to the Run or Debug directory

### Driver Classes
FirefoxDriver and ChromeDriver classes are inherited from RemoteWebDriver class

RemoteWebDriver class implements multiple interfaces and some are IWebDriver, IDisposable, IJavaScriptExecutor and so on

### Firefox Add On
In case if you are using Firefox please install the [Selenium addon](https://addons.mozilla.org/en-US/firefox/addon/selenium-ide/).