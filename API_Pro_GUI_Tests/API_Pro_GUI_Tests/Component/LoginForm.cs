using OpenQA.Selenium;

namespace API_Pro_GUI_Tests.Component
{
    public class LoginForm : Component
    {
        public LoginForm(IWebDriver webDriver) : base(webDriver) {   }

        public override bool IsRendered()
        {
            return WebDriver.FindElements(By.ClassName("a-login-form-wrapper")).Count != 0;
        }

        public void FillUsernameField(string username)
        {
            var usernameField = WebDriver.FindElement(By.XPath("//div[contains(@class, 'a-login-form-wrapper')]/descendant::input[contains(@name, 'uuser_id')]"));
            usernameField.Clear();
            usernameField.SendKeys(username);
        }

        public void ClickLoginButton()
        {
            WebDriver.FindElement(By.XPath("//div[contains(@class, 'a-login-form-wrapper')]/descendant::a[contains(@class, 'x-btn')]")).Click();
        }
    }
}
