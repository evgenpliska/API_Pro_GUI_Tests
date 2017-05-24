using API_Pro_GUI_Tests.Component;
using OpenQA.Selenium;

namespace API_Pro_GUI_Tests.Page
{
    public abstract class Page
    {
        protected string Url { get; }

        protected IWebDriver WebDriver { get; }

        public Loader Loader { get; }

        protected Page(string url, IWebDriver webDriver)
        {
            Url = url;
            WebDriver = webDriver;
            Loader = new Loader(WebDriver);
        }

        public abstract bool IsReady();

        public void NavigateTo()
        {
            WebDriver.Navigate().GoToUrl(Url);
        }
    }
}