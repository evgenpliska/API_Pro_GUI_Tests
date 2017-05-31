using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace API_Pro_GUI_Tests.Component
{
    public class LogoApipro : Component
    {
        public LogoApipro(IWebDriver webDriver) : base(webDriver) { }
        
        public override bool IsReady()
        {
            return WebDriver.FindElements(By.Id("image-1057")).Count == 1;
        }

        public bool IsLogoVisible()
        {
            return WebDriver.FindElement(By.Id("image-1057")).Displayed;
        }
    }
   
}
