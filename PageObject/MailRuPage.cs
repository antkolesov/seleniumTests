using OpenQA.Selenium;
using SeleniumTests.DriverManager;

namespace SeleniumTests.PageObject
{
    public class MailRuPage
    {
        private IWebDriver driver;

        public MailRuPage()
        {
            driver = DriverHelper.GetDriver();

        }

        /// <summary>
        /// Раздел "Мой мир"
        /// </summary>
        public IWebElement MyWorldSection => driver.FindElement(By.LinkText("Мой Мир"));

    }
}
