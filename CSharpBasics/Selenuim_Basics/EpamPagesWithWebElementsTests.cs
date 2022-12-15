
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenuim_Basics
{
    [TestFixture]
    public class EpamPagesWithWebElementsTests
    {
        private IWebDriver Driver { get; set; }

        private const string _wordToSearchIsAutomation = "Automation";
        private const string _wordToSearchIsBusinessAnalysis = "Business Analysis";
        private const string _wordToSearchIsBlockchain = "Blockchain";

        private const string _mainLinkPage = "https://www.epam.com/";
        private const string _careersButtonXPath = "//*[@class ='top-navigation__item-link' and @href = '/careers']";
        private const string _tabsWithCountriesXPath = "//*[contains(@class, 'tabs__title')]";
        private const string _searchButtonMainPageXPath = "//*[@class = 'header-search__button header__icon']";
        private const string _searchFieldXPath = "//input[@name = 'q']";
        private const string _findButtonXPath = "//*[@class = 'header-search__submit']";
        private const string _searchResultItemXPath = "//*[@class = 'search-results__item']";
        private const string _titleOfFirstArticleOnSearchPageXPath = "//*[@class = 'search-results__item'][1]/h3/descendant::a";
        private const string _titleOfArticleOnPageOpenedArticleXPath = "//h1[contains(@class, 'title-ui title--center')]";

        [SetUp]
        public void Initialazed()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_mainLinkPage);
        }

        [Test]
        public void CheckPageContainsThreeRegion()
        {
            var expectedResult = new List<string> { "AMERICAS", "EMEA", "APAC" };


            var webElement = Driver.FindElement(By.XPath(_careersButtonXPath));
            webElement.Click();


            var webElementThreeCountries = Driver.FindElements(By.XPath(_tabsWithCountriesXPath));

            foreach (var item in webElementThreeCountries)
            {
                Assert.True(expectedResult.Contains(item.GetAttribute("innerText")));
            }
        }

        [TestCase(_wordToSearchIsAutomation)]
        [TestCase(_wordToSearchIsBusinessAnalysis)]
        public void CheckOpenPageWithUrlContainInputWord(string input)
        {
            OpenSearchPanel();
            SearchByInputString(input);

            Assert.That(Driver.Url.Contains(input.Replace(' ', '+')), Is.True, $"Opened page URL {Driver.Url} doesn't contain searched word {input}.");
        }

        [TestCase(_wordToSearchIsAutomation)]
        public void CheckPageContainElementWithInputWord(string input)
        {
            OpenSearchPanel();
            SearchByInputString(input);

            var fiveFirstItems = Driver.FindElements(By.XPath(_searchResultItemXPath)).Take(5);
            foreach (var item in fiveFirstItems)
            {
                Assert.That(item.GetAttribute("innerText").Contains(input, StringComparison.OrdinalIgnoreCase), Is.True, $"{item.GetAttribute("innerText")} doesn't contain {input}.");
            }
        }

        [TestCase(_wordToSearchIsAutomation)]
        [TestCase(_wordToSearchIsBlockchain)]
        [TestCase(_wordToSearchIsBusinessAnalysis)]

        public void CheckTitleFirstArticalIsEqualTitleOpenedPage(string input)
        {
            OpenSearchPanel();
            SearchByInputString(input);

            var firstArticalElement = Driver.FindElement(By.XPath(_titleOfFirstArticleOnSearchPageXPath));
            var titleOfFirstArticle = firstArticalElement.Text;
            firstArticalElement.Click();

            var titleOfOpenedPage = Driver.FindElement(By.XPath(_titleOfArticleOnPageOpenedArticleXPath));
            var title = titleOfOpenedPage.Text;

            Assert.That(titleOfOpenedPage.Text.Contains(titleOfFirstArticle), $"Title of opened page {titleOfOpenedPage.Text} but title of article on searche page is {titleOfFirstArticle}.");
        }

        private void OpenSearchPanel()
        {
            var searchButton = Driver.FindElement(By.XPath(_searchButtonMainPageXPath));
            searchButton.Click();
        }

        private void SearchByInputString(string input)
        {
            Driver.FindElement(By.XPath(_searchFieldXPath)).SendKeys(input);
            Driver.FindElement(By.XPath(_findButtonXPath)).Click();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}


#region Task_6

// 1. https://www.epam.com/services/consult-and-design  //*[@class = 'categories-switcher__tile-title categories-switcher__nav-item'][last()-1]
// 2. https://www.epam.com/about  //*[@class = 'text']/preceding-sibling::div[@class = 'layout-box']
// 3. https://www.epam.com/about //*[contains(text(), 'Learn more')]/parent::a
// 4. https://www.epam.com/about //*[@class = 'news-events__all-link' and @aria-label = 'Follow the link to read all News']
// 5. https://www.epam.com/services/operate //*[@class = 'js-tabs-title--sub']//following-sibling::div

#endregion
