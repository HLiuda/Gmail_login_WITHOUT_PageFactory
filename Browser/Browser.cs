using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gmail_login_with_PageFactory
{ 
public class Browser
{
    //private static IWebDriver Driver { get; set; }
    private static IWebDriver driver;
    public static IWebDriver Driver

    {
        get { return driver; }

        private set
        {
            driver = value;
        }
    }
    public static void StartBrowser(String browser)
    {
        switch (browser)
        {
            case "Firefox":
                //  Driver = new FirefoxDriver();
                break;
            case "Chrome":
                Driver = new ChromeDriver();
                break;
            case "InternetExplorer":
                break;
            default:
                break;
        }
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        Driver.Manage().Window.Maximize();
        //  Driver.Navigate().GoToUrl(@"https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");

    }

    public static void CloseBrowser()
    {
        Driver.Quit();
    }
}
}