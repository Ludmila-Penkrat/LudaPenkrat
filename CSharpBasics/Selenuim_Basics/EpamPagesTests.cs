using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenuim_Basics
{
    public class EpamPagesTests
    {
        private IWebDriver _webDriver;
        public string MainLinkPage = "https://www.epam.com/";
        public string WeDoItPageLink = "https://www.epam.com/how-we-do-it";
        public string OurWorkPageLink = "https://www.epam.com/our-work";

        [SetUp]
        public void Initialaze()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();

        }

        [Test]
        public void CheckCorrectPageIsOpened()
        {
            _webDriver.Navigate().GoToUrl(MainLinkPage);

            Assert.That(_webDriver.Url, Is.EqualTo(MainLinkPage), $"Expected result is {MainLinkPage} but actual result is {_webDriver.Url}");
        }

        [Test]
        public void CheckWeDoItPageIsOpenedAfterMoveAndReload()
        {
            _webDriver.Navigate().GoToUrl(WeDoItPageLink);
            _webDriver.Navigate().GoToUrl(OurWorkPageLink);
            _webDriver.Navigate().Refresh();
            _webDriver.Navigate().Back();

            Assert.That(_webDriver.Url, Is.EqualTo(WeDoItPageLink), $"Expected result {MainLinkPage} is'n equal to actual result {_webDriver.Url}");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}