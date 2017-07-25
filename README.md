# Selenium WebDriver Demo
This repository contains sample code for implementing Automation for Selenium's WebDriver.

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