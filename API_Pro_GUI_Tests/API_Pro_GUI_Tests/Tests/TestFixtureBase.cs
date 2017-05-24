using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace API_Pro_GUI_Tests.Tests
{
    [TestFixture]
    public abstract class TestFixtureBase
    {
        protected IWebDriver WebDriver;

        [SetUp]
        public void SetUp()
        {
            WebDriver = new ChromeDriver();
        }
    }
}
