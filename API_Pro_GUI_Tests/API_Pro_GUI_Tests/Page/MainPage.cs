using OpenQA.Selenium;

namespace API_Pro_GUI_Tests.Page
{
    public class MainPage : Page
    {
        public const string MainPageUrl = "http://qa.apipro.pp.ciklum.com/";

        public override bool IsReady()
        {
            return true;
        }

        public MainPage(IWebDriver webDriver) : base(MainPageUrl, webDriver)
        {
        }
    }
}
