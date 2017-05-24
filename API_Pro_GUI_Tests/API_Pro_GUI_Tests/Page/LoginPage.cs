using API_Pro_GUI_Tests.Component;
using OpenQA.Selenium;

namespace API_Pro_GUI_Tests.Page
{
    public class LoginPage : Page
    {
        public const string LoginPageUrl = "http://qa.apipro.pp.ciklum.com/";

        public LoginForm LoginForm { get; }

        public LoginPage(IWebDriver webDriver) : base(LoginPageUrl, webDriver)
        {
            LoginForm = new LoginForm(webDriver);
        }

        public override bool IsReady()
        {
            return LoginForm.IsReady() && !Loader.IsVisible();
        }
    }
}
