using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_login_with_PageFactory
{
    class InboxPage : BasePage
    {
        private IWebDriver driver;
        public InboxPage()
        {
            this.driver = Browser.Driver;
            PageFactory.InitElements(Browser.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Inbox']")]
        public IWebElement Inbox;
    }
}
