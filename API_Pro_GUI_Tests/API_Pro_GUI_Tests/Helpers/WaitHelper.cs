using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace API_Pro_GUI_Tests.Helpers
{
    public static class WaitHelper
    {
        public const int DefaultWaitTime = 15000;

        public static void WaitUntil(IWebDriver webDriver, Func<bool> condition, int maxWaitTimeInMillis = DefaultWaitTime, string errorMessage = "Criteria hasn't been satisfied in passed timeout")
        {
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, maxWaitTimeInMillis));
            if (!wait.Until(wd => condition()))
                throw new TimeoutException(errorMessage);
        }
    }
}
