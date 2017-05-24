using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace API_Pro_GUI_Tests.Component
{
    public class Loader : Component
    {
        private readonly By _selector = By.XPath("//*[contains(@id,'loadmask')]");

        public Loader(IWebDriver webDriver) : base(webDriver) {}

        public override bool IsReady()
        {
            return WebDriver.FindElements(_selector).Count != 0;
        }

        public bool IsVisible()
        {
            if (!IsReady())
                return false;

            var element = WebDriver.FindElement(_selector);
            return element.Displayed;
        }
    }
}
