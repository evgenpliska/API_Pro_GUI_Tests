using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace API_Pro_GUI_Tests.Component
{
    public class LoginForm : Component
    {
        public LoginForm(IWebDriver webDriver) : base(webDriver) {   }

        public override bool IsReady()
        {
            return WebDriver.FindElements(By.ClassName("a-login-form-wrapper")).Count != 0;
        }

        public void FillUsernameField(string username)
        {
            var usernameField = WebDriver.FindElement(By.XPath("//div[contains(@class, 'a-login-form-wrapper')]/descendant::input[contains(@name, 'uuser_id')]"));
            usernameField.Clear();
            usernameField.SendKeys(username);
        }

        public void FillPasswordField(string password)
        {
            var passwordField = WebDriver.FindElement(By.Name("upassword"));
            passwordField.Clear();
            passwordField.SendKeys(password);

        }

        public void ChooseActiveDiectoryField()
        {
            var activedirectoryField = WebDriver.FindElement(By.Name("activedirectory"));
            activedirectoryField.Click();
            var selectElement = new SelectElement(activedirectoryField);
            selectElement.SelectByText("APIPRO");
            activedirectoryField.Click();
                 
        }

        public void ChooseLanguageField()
        {
            var languageField = WebDriver.FindElement(By.Name("language"));
            languageField.Click();
            var selectElement = new SelectElement(languageField);
            selectElement.SelectByText("English (default)");
            languageField.Click();
        }

        public void ClickOnCheckBox()
        {
            WebDriver.FindElement(By.Name("rememberme")).Click();
        }
        public void ClickLoginButton()
        {
            WebDriver.FindElement(By.XPath("//div[contains(@class, 'a-login-form-wrapper')]/descendant::a[contains(@class, 'x-btn')]")).Click();
        }
    }
}
