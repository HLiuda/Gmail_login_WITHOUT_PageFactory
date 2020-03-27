
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_login_with_PageFactory
{
    [TestFixture]
    class TestBase
    {

        private IWebDriver driver;
        [SetUp]
        public void BedoreClass()
        {
            Browser.StartBrowser("Chrome");
            //  driver.Navigate().GoToUrl(@"https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

        }


        [TearDown]
        public void AfterClass()
        {
            Browser.CloseBrowser();
        }
    }
}