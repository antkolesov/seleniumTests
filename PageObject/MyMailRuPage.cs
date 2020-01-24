using OpenQA.Selenium;
using SeleniumTests.DriverManager;

namespace SeleniumTests.PageObject
{
    public class MyMailRuPage
    {
        private IWebDriver driver;

        public MyMailRuPage()
        {
            driver = DriverHelper.GetDriver();
        }

        public IWebElement Login => driver.FindElement(By.XPath("//input[@tabindex = '1']"));
        //Поле ввода логина

        public IWebElement Password => driver.FindElement(By.XPath("//input[@tabindex = '2']"));
        //Поле ввода пароля

        public IWebElement Button => driver.FindElement(By.XPath("//input[@tabindex = '4']"));
        //Кнопка "Войти"
    }
}
