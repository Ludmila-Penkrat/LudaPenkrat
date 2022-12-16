using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumTest
{
    public class SeleniumTests
    {
        public IWebDriver Driver;
        private const string _mainLinkPage = "https://www.epam.com/";
        private const string _careerLocationkPage = "https://www.epam.com/careers/locations";

        private const string _careersButtonOnHeaderXPath = "//*[@class = 'top-navigation__item-link' and @href='/careers']";
        private const string _hiringLocationXPath = "//*[@class='top-navigation__main-link'  and @href='/careers/locations']";
        private const string _buttonApplyXPath = "//*[@class='button-ui bg-color-light-blue standard']";

        [SetUp]
        public void Initialaze()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_mainLinkPage);

        }

        [Test]
        public void CheckElemenHeaderIsPresentOnMainPage()
        {
            var headerOnMainPage = Driver.FindElement(By.TagName("header"));
            Assert.IsTrue(headerOnMainPage.Displayed, $"The element {headerOnMainPage} is present on the main page");

        }

        [Test]
        public void CheckApplyButtonOnLocationsPage()
        {
            var element = Driver.FindElement(By.XPath(_careersButtonOnHeaderXPath));

            var action = new Actions(Driver);
            action.MoveToElement(element).Build().Perform();

            var hiringLocationMenu = Driver.FindElement(By.XPath(_hiringLocationXPath));
            hiringLocationMenu.Click();

            Assert.That(Driver.Url, Is.EqualTo(_careerLocationkPage), $"The page with {_careerLocationkPage} doesn't open");

            var buttonApply = Driver.FindElement(By.XPath(_buttonApplyXPath));
            action.ScrollToElement(buttonApply).Build().Perform();

            Assert.That(buttonApply.Displayed, Is.True, $"Button Apply is not visible");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}