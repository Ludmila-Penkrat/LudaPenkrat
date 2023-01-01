using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.IndexedDB;
using OpenQA.Selenium.Interactions;

namespace Selenium_Advanced
{
    public class EpamPageWithWaitingWebElementsTests : BaseTests
    {
        private const string _careersJoinOurTeamPage = "https://www.epam.com/careers/job-listings";

        private const string _careersButtonHeaderMenuMainPageXPath = "//*[@class = 'top-navigation__item-link' and @href = '/careers']";
        private const string _careersJoinOurTeamLinkDropMenuXPath = "//*[@class = 'top-navigation__main-link' and @href = '/careers/job-listings']";
        private const string _chooseLanguageButtonMaimPageXPath = "//*[@class = 'location-selector__button']";
        private const string _listOfAllLanguagesInDropDownXPath = "//*[@class ='location-selector__item']";
        private const string _searchButtonMainPageXPath = "//*[@class = 'header-search__button header__icon']";
        private const string _searchPanelXPath = "//*[@class = 'header-search__panel opened']";
        //private const string _firstLineInSearchPanelXPath = "//*[@class = 'frequent-searches__item'][1]";
        private const string _firstLineInSearchPanelXPath = "//*[@class = 'frequent-searches__items']/descendant::li[1]";
        private const string _findButtonXPath = "//*[@class = 'header-search__submit']";
        private const string _viewMoreLinkOnSearchPanelXPath = "//*[@class = 'search-results__footer']";
        private const string _articlesListOnSearchePageXPath = "//*[@class = 'search-results__item']";


        [Test]
        public void CheckJoinOurTeamCareerSubMenuIsOpenedTest()
        {
            Actions.MoveToElement(Driver.FindElement(By.XPath(_careersButtonHeaderMenuMainPageXPath))).Build().Perform();

            var careerJoinOurTeamLink = Driver.FindElement(By.XPath(_careersJoinOurTeamLinkDropMenuXPath));
            JsExecutor.ExecuteScript("arguments[0].click()", careerJoinOurTeamLink);

            Assert.That(Driver.Url, Is.EqualTo(_careersJoinOurTeamPage), $"The incorrect URL is opened {Driver.Url} instead {_careersJoinOurTeamPage}");
        }

        [Test]
        public void CheckAllLanguagesArePresentInDropDownTest()
        {
            List<string> expectedListAllLanguages = new List<string>
            {
                "Global (English)",
                "Hungary (English)",
                "СНГ (Русский)",
                "Česká Republika (Čeština)",
                "India (English)",
                "Україна (Українська)",
                "Czech Republic (English)",
                "日本 (日本語)",
                "中国 (中文)",
                "DACH (Deutsch)",
                "Polska (Polski)"
            };

            Driver.FindElement(By.XPath(_chooseLanguageButtonMaimPageXPath)).Click();
            
            var allLanguagesInDropDown = Waiter.Until(Driver => Driver.FindElements(By.XPath(_listOfAllLanguagesInDropDownXPath)))
                                        .Select(x => x.GetAttribute("innerText"));
         
            CollectionAssert.AreEqual(expectedListAllLanguages, allLanguagesInDropDown, $"Collection {string.Join(", ", expectedListAllLanguages)} does not match with collection on site {string.Join(", ", allLanguagesInDropDown)}.");
        }

        [Test]
        public void CheckTwentyArticlesIsPresentOnSearchPageTest()
        {
            var expectedCountArticlesOnSearchPage = 20;

            Driver.FindElement(By.XPath(_searchButtonMainPageXPath)).Click();

            Waiter.Until(Driver => Driver.FindElement(By.XPath(_firstLineInSearchPanelXPath)).Displayed);

            Actions.MoveToElement(Driver.FindElement(By.XPath(_firstLineInSearchPanelXPath))).Click().Build().Perform();

            Driver.FindElement(By.XPath(_findButtonXPath)).Click();

            Actions.ScrollToElement(Driver.FindElement(By.XPath(_viewMoreLinkOnSearchPanelXPath))).Build().Perform();

            var articlesList = Driver.FindElements(By.XPath(_articlesListOnSearchePageXPath));

            Assert.That(articlesList, Has.Count.EqualTo(expectedCountArticlesOnSearchPage), $"The list of articles less or more than expected count: {expectedCountArticlesOnSearchPage}");
        }
    }
}