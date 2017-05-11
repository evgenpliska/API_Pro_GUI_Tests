using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Pro_GUI_Tests.AppManager;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace API_Pro_GUI_Tests.Tests
{
    class TestBase
    {
        protected ApplicationManager App;

        [SetUp]
        public void SetupApplicationManager()
        {
            App = ApplicationManager.GetInstance();
        }

    }
}
