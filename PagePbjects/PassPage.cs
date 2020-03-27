using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_login_with_PageFactory
{
    class PassPage : BasePage
    {
        private IWebDriver driver;
        public PassPage()
        {
            this.driver = Browser.Driver;
            PageFactory.InitElements(Browser.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']//input")]
        public IWebElement Pass;
        //private IWebElement Pass { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='passwordNext']")]
        public IWebElement PassSubmit;
    }
}
