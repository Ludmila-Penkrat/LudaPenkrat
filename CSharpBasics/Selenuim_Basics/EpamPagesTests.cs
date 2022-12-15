using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenuim_Basics
{
    public class EpamPagesTests
    {
        private IWebDriver _webDriver;
        private const string _weDoItPageLink = "https://www.epam.com/how-we-do-it";
        private const string _ourWorkPageLink = "https://www.epam.com/our-work";
        private const string _mainLinkPage = "https://www.epam.com/";

        [SetUp]
        public void Initialaze()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();

        }

        [Test]
        public void CheckCorrectPageIsOpened()
        {
            _webDriver.Navigate().GoToUrl(_mainLinkPage);

            Assert.That(_webDriver.Url, Is.EqualTo(_mainLinkPage), $"Expected result is {_mainLinkPage} but actual result is {_webDriver.Url}");
        }

        [Test]
        public void CheckWeDoItPageIsOpenedAfterMoveAndReload()
        {
            _webDriver.Navigate().GoToUrl(_weDoItPageLink);
            _webDriver.Navigate().GoToUrl(_ourWorkPageLink);
            _webDriver.Navigate().Refresh();
            _webDriver.Navigate().Back();

            Assert.That(_webDriver.Url, Is.EqualTo(_weDoItPageLink), $"Expected result {_mainLinkPage} is'n equal to actual result {_webDriver.Url}");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}