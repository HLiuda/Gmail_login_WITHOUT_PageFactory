using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_login_with_PageFactory
{
    class AddressPage : BasePage
    {
        private IWebDriver driver;
        // AddressPage addressPage = new AddressPage();  

        public AddressPage()
        {
            this.driver = Browser.Driver;
            PageFactory.InitElements(Browser.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='identifierId']")]
        public IWebElement Email; //{ get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='identifierNext']")]
        public IWebElement MailSubmit;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(@"https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

        }
    }
}