using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace FinalTest.Tests
{
    [TestFixture]
    public class EpamTests
    {
        private IWebDriver Driver;
        private const string _mainPageUrl = "https://www.epam.com/";
        private const string _careersPageUrl = "https://www.epam.com/careers";

        private const string _learnMoreButtonCareersPageXPath = "//*[@class='button-ui bg-color-white standard']";


        [SetUp]
        public void Initialaize()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_mainPageUrl);
        }

        public void CheckLearnMoreButtonIsPresentOnCareersPage()
        {
            Driver.Navigate().GoToUrl(_careersPageUrl);
            var learmMoreButtons = Driver.FindElements(By.XPath(_learnMoreButtonCareersPageXPath)).ToList();

            Assert.That(learmMoreButtons.First().Displayed, Is.True, "The Learn More button is not present on the page");
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
