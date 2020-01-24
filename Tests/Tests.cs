using NUnit.Framework;
using SeleniumTests.DriverManager;
using SeleniumTests.PageObject;

namespace SeleniumTests.Tests
{
    public class Tests
    {
        MailRuPage mailRuPage = new MailRuPage();
        MyMailRuPage myMailRuPage = new MyMailRuPage();
        MyMailBoxPage mailBoxPage = new MyMailBoxPage();

        [Test]
        public void Mail()
        {
            DriverHelper.GetDriver().Navigate().GoToUrl("https://mail.ru/");

            mailRuPage.MyWorldSection.Click();
            myMailRuPage.Login.SendKeys("testaccountfortest2@mail.ru");
            myMailRuPage.Password.SendKeys("123123123Test");
            myMailRuPage.Button.Click();

            mailBoxPage.MailSection.Click();
            mailBoxPage.ForWriteLetterBtn.Click();
            mailBoxPage.ToWhoField.SendKeys("pro100skyanton@mail.ru");
            mailBoxPage.TitleField.SendKeys("Тест");
            mailBoxPage.СontentMailField.SendKeys("Здравствуйте!\nПисьмо было отправлено со стороннего ПО. Просьба не отвечать на это сообщение.");
            mailBoxPage.ForSendLetterBtn.Click();
            Assert.AreEqual("отправлено", mailBoxPage.ForAcceptField.Text);
        }

    }
}
