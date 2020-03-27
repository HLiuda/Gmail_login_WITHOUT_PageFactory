using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_login_with_PageFactory
{

    class BasePage
    {
        // private IWebDriver driver;

        // public BasePage() { }
        public void ElementClick(IWebElement element)
        {
            element.Click();
        }

        public void Insert(IWebElement element, String input)
        {
            element.SendKeys(input);
        }
    }
}
