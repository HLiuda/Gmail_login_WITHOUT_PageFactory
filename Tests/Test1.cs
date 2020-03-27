
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_login_with_PageFactory.Tests
{
    [TestFixture]
    class Test1 : TestBase
    {

        // public IWebDriver driver;    працює із ним і без нього
        [Test]
        public void login()
        {
            //driver.Navigate().GoToUrl(@"https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            AddressPage addressPage = new AddressPage();
            PassPage passPage = new PassPage();
            InboxPage inboxPage = new InboxPage();

            addressPage.GoToPage();
            addressPage.Insert(addressPage.Email, "4automation1@gmail.com");
            addressPage.ElementClick(addressPage.MailSubmit);
            passPage.Insert(passPage.Pass, "!TestAccount1");
            passPage.ElementClick(passPage.PassSubmit);
            //   inboxPage.ElementClick(inboxPage.Inbox);
            addressPage.ElementClick(addressPage.MailSubmit);



        }

    }
}

