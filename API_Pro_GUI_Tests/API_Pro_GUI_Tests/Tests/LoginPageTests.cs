using API_Pro_GUI_Tests.Helpers;
using API_Pro_GUI_Tests.Page;
using NUnit.Framework;

namespace API_Pro_GUI_Tests.Tests
{
    public class LoginPageTests : TestFixtureBase
    {
        private LoginPage _loginPage;
        private MainPage _mainPage;

        [SetUp]
        public void SetupTest()
        {
            _loginPage = new LoginPage(WebDriver);
            _mainPage = new MainPage(WebDriver);
        }

        [Test]
        public void FillUsername_ClickLoginButton_MainMenuSeen()
        {
            _loginPage.NavigateTo();            
            WaitHelper.WaitUntil(WebDriver, _loginPage.IsReady);

            _loginPage.LoginForm.FillUsernameField("epl");
            _loginPage.LoginForm.ClickLoginButton();

            WaitHelper.WaitUntil(WebDriver, _mainPage.IsReady);

            Assert.That(_mainPage.IsReady);
        }
    }
}
