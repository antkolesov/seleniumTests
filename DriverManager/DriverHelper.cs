using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTests.DriverManager
{
    public static class DriverHelper
    {
        private static IWebDriver driver;

        [SetUp]
        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                var options = new ChromeOptions();
                driver = new ChromeDriver(options);

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(20);
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
                driver.Manage().Window.Maximize();
                driver.Manage().Cookies.DeleteAllCookies();
            }

            return driver;
        }

        [TearDown]
        public static void TearDown()
        {

            if (driver != null)
                driver.Quit();
        }


    }
}
