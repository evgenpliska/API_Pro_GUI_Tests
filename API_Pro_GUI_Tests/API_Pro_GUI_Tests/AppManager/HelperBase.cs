using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;

namespace API_Pro_GUI_Tests.AppManager
{

    public class HelperBase
    {
        protected readonly IWebDriver Driver;
        protected readonly ApplicationManager Manager;

        protected HelperBase(ApplicationManager manager)
        {
            this.Manager = manager;
            Driver = manager.Driver;
        }

        protected void ClickOn(By locator)
        {
            var element = Driver.FindElement(locator);
            element.Click();
        }

        protected void FillWith(By locator, string text)
        {
            var element = Driver.FindElement(locator);
            element.SendKeys(text);
        }

        protected int CountElements(By by)
        {
            var quantity = Driver.FindElements(by).Count;
            return quantity;
        }

        protected static void DelayTime(float waitTime)
        {
            Thread.Sleep((int)(waitTime * 1000));
        }

        protected bool IsElementPresent(By by)
        {
            var element = Driver.FindElements(by);
            var quantity = element.Count;

            return quantity > 0;
        }

        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }
    }
}
