using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace API_Pro_GUI_Tests.AppManager
{
    public class ApplicationManager
    {
        private static readonly ThreadLocal<ApplicationManager> App = new ThreadLocal<ApplicationManager>();
        private readonly string BaseUrl = "qa.apipro.pp.ciklum.com";

        private ApplicationManager()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            Auth = new LoginHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {
                Driver.Quit();
            }
            catch
            {
                // ignored
            }
        }

        public IWebDriver Driver { get; set; }

        public LoginHelper Auth { get; set; }

        public static ApplicationManager GetInstance()
        {
            if (App.IsValueCreated) return App.Value;
            var newInstance = new ApplicationManager();
            App.Value = newInstance;
            return App.Value;
        }
    }
}
