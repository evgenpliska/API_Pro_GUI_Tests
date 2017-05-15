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
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://qa.apipro.pp.ciklum.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTest()
        {
            //Login
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("ext-47-inputEl")).Clear();
            driver.FindElement(By.Id("ext-47-inputEl")).SendKeys("");
            driver.FindElement(By.Id("ext-47-inputEl")).Clear();
            driver.FindElement(By.Id("ext-47-inputEl")).SendKeys("epl");
            driver.FindElement(By.XPath("//td[@id='ext-element-39']/div/div")).Click();
            //Main menu - OpenPositionTab
            driver.FindElement(By.XPath("//td[@id='ext-element-46']/div/div[2]")).Click();
            driver.FindElement(By.XPath("//table[@id='treeview-1088-record-51']/tbody/tr/td/div/span")).Click();
            driver.FindElement(By.Id("usersection-user-1072-btnEl")).Click();
            // 
            driver.FindElement(By.Id("menucheckitem-1077-textEl")).Click();
            driver.FindElement(By.Id("usersection-user-1072-btnEl")).Click();
            driver.FindElement(By.Id("menuitem-1079-textEl")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
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
                driver.SwitchTo().Alert();
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
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
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
                acceptNextAlert = true;
            }
        }
    }
}