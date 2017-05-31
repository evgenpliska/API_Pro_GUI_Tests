using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace API_Pro_GUI_Tests.Component
{
    public class ErroreLoginMessage : Component
    {
        public ErroreLoginMessage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public override bool IsReady()
        {
            return WebDriver.FindElements(By.Id("button-1063-btnEl")).Count == 1;
        }

        public void LoginMessageErrore()
        {
            var erroreMessage = WebDriver.FindElement(By.Id("button-1063-btnEl"));
            erroreMessage.Click();

        }

    }
}