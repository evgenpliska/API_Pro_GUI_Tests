using OpenQA.Selenium;

namespace API_Pro_GUI_Tests.Component
{
    public abstract class Component
    {
        protected IWebDriver WebDriver { get; }

        public abstract bool IsReady();

        protected Component(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}
