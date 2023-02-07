using NUnit.Framework;

namespace FinalTest.Tests
{
    [TestFixture]
    public class TrainingTests : BaseTest
    {
        private TrainingMainPage MainPage;

        private const string _mainLinkTrainingPage = "https://training.by/";


        [SetUp]
        public void Initialaze()
        {
            MainPage = new TrainingMainPage();
        }

        [TestCase(Languages.ENGLISH)]
        [TestCase(Languages.–”—— »…)]
        [TestCase(Languages.” –¿ØÕ—‹ ¿)]
        public void CheckCorrectPageIsOpened(Languages language)
        {
            Driver.Navigate().GoToUrl(_mainLinkTrainingPage);

            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            MainPage.OpenLanguagesDropDown();

            MainPage.SelectLanguageInDropDown(language);

            Thread.Sleep(2000);

            var expectedResult = MainPage.IsPageWithSelectedLanguageIsOpened(language);

            Assert.That(expectedResult, Is.True, "Page on the selected languages isn't opened");
        }
    }
}