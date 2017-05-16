using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace API_Pro_GUI_Tests.Tests
{
    [TestFixture]
    public class TestBase
    {
        public IWebDriver Driver;
        private StringBuilder _verificationErrors;
        private string _baseUrl;
        private bool _acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            Driver = new ChromeDriver();
            _baseUrl = "http://qa.apipro.pp.ciklum.com/";
            _verificationErrors = new StringBuilder();
        }

        public void LoginPage()
        {
            
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", _verificationErrors.ToString());
        }

        public void Login()
        { 
            LoginPage("epl");
            OpenPositionTab();
            Logout();
        }

        private void Logout()
        {
            Driver.FindElement(By.Id("usersection-user-1072-btnEl")).Click();
            Driver.FindElement(By.Id("menuitem-1079-textEl")).Click();
        }

        private void OpenPositionTab()
        {
            Driver.FindElement(By.XPath("//td[@id='ext-element-46']/div/div[2]")).Click();
            Driver.FindElement(By.XPath("//table[@id='treeview-1088-record-51']/tbody/tr/td/div/span")).Click();
            Driver.FindElement(By.Id("usersection-user-1072-btnEl")).Click();
            Driver.FindElement(By.Id("menucheckitem-1077-textEl")).Click();
        }

        private void LoginPage(string username)
        {
            Driver.Navigate().GoToUrl(_baseUrl + "/");
            Driver.FindElement(By.Id("ext-47-inputEl")).Clear();
            Driver.FindElement(By.Id("ext-47-inputEl")).SendKeys("");
            Driver.FindElement(By.Id("ext-47-inputEl")).Clear();
            Driver.FindElement(By.Id("ext-47-inputEl")).SendKeys("username");
            Driver.FindElement(By.XPath("//td[@id='ext-element-39']/div/div")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = Driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (_acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                _acceptNextAlert = true;
            }
        }
    }
}