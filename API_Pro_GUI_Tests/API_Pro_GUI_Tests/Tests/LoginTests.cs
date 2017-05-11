using NUnit.Framework;

namespace API_Pro_GUI_Tests.Tests
{
    [TestFixture]
    class LoginTests:TestBase
    {

        [Test]
        public void LoginTest()
        {
               App.Auth.Login();
               App.Auth.LogOut();
        }

    }
}
