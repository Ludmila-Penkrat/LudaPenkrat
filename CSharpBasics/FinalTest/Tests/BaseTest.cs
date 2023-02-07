using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void InitialazeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            //Driver.Navigate().GoToUrl(_mainPage);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.1);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
