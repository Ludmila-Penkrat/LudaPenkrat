using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Advanced
{
    public class BaseTests
    {
        public IWebDriver Driver { get; set; }
        public Actions Actions { get; set; }
        public WebDriverWait Waiter { get; set; }
        public IJavaScriptExecutor? JsExecutor { get; set; }

        private TimeSpan _timeSpan = TimeSpan.FromSeconds(30);

        private const string _mainPage = "https://www.epam.com/";


        [SetUp]
        public void InitialazeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_mainPage);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.1);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
        }

        [SetUp]
        public void SetUpActions()
        {
            Actions = new Actions(Driver);
        }

        [SetUp]
        public void SetUpWaiter()
        {
            Waiter = new WebDriverWait(Driver, _timeSpan);
        }

        [SetUp]
        public void SetUpJavaScriptExecutor()
        {
            JsExecutor = Driver as IJavaScriptExecutor;
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
