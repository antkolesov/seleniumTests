using OpenQA.Selenium;
using SeleniumTests.DriverManager;

namespace SeleniumTests.PageObject
{
    public class MyMailBoxPage
    {
        private IWebDriver driver;

        public MyMailBoxPage()
        {
            driver = DriverHelper.GetDriver();
        }

        /// <summary>
        /// Раздел "Почта"
        /// </summary>
        public IWebElement MailSection => driver.FindElement(By.XPath("//i[@id = 'g_mail_events']"));

        /// <summary>
        /// Кнопка "Написать"
        /// </summary>
        public IWebElement ForWriteLetterBtn => driver.FindElement(By.ClassName("compose-button__txt"));

        /// <summary>
        /// Поле письма "Кому"
        /// </summary>
        public IWebElement ToWhoField => driver.FindElement(By.XPath("//input[@tabindex = '100']"));

        /// <summary>
        /// Поле письма "Тема"
        /// </summary>
        public IWebElement TitleField => driver.FindElement(By.XPath("//input[@tabindex = '400']"));

        /// <summary>
        /// Содержимое письма
        /// </summary>
        public IWebElement СontentMailField => driver.FindElement(By.XPath("//div[@tabindex = '505']"));

        /// <summary>
        /// Кнопка "Отправить"
        /// </summary>
        public IWebElement ForSendLetterBtn => driver.FindElement(By.XPath("//span[@tabindex = '570']"));

        /// <summary>
        /// Текст "Отправлено"
        /// </summary>
        public IWebElement ForAcceptField => driver.FindElement(By.XPath("//div[@class = 'layer__header']/span"));
    }
}
