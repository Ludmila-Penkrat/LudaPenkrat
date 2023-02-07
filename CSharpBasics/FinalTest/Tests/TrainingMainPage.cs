using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Tests
{
    public class TrainingMainPage : BaseTest
    {       

        private const string _mainLinkTrainingPage = "https://training.by/";

        private const string _languageToggleXPath = "//*[contains(@class, 'menu-control language-control dropdown')";
        private const string _languageDropDownXPath = "//*[contains(@class, 'language-control__menu dropdown-menu')]";
        private const string _languagesInDropDownXPath = "//*[contains(@class, 'language-control__item')]";

        private const string _enLanguageIconXPath = "//*[contains(@class, 'menu-control__toggle')] [contains(text(), 'EN')]";
        private const string _ruLanguageIconXPath = "//*[contains(@class, 'menu-control__toggle')] [contains(text(), 'RU')]";
        private const string _uaLanguageIconXPath = "//*[contains(@class, 'menu-control__toggle')] [contains(text(), 'UA')]";

        private const string _enInDropDownXPath = "//a[contains(@class, 'language-control__item')][contains(text(), 'English')]";
        private const string _ruInDropDownXPath = "//a[contains(@class, 'language-control__item')][contains(text(), 'Русский')]";
        private const string _uaInDropDownXPath = "//a[contains(@class, 'language-control__item')][contains(text(), 'Українська')]";

        public void TrainingMainPageIsOpened()
        {
            Driver.Url.Equals(_mainLinkTrainingPage);
        }

        public void OpenLanguagesDropDown()
        {
            Driver.FindElement(By.XPath(_languageToggleXPath)).Click();
        }

        public bool LanguagesDropDownIsOpened()
        {
            var dropDown = Driver.FindElement(By.XPath(_languageDropDownXPath));
            return dropDown.Enabled;
        }

        public void SelectLanguageInDropDown(Languages languages)
        {
      
            switch (languages)
            {
                case Languages.ENGLISH:
                    Driver.FindElement(By.XPath(_enInDropDownXPath)).Click();
                    break;
                case Languages.РУССКИЙ:
                    Driver.FindElement(By.XPath(_ruInDropDownXPath)).Click();
                    break;
                case Languages.УКРАЇНСЬКА:
                    Driver.FindElement(By.XPath(_uaInDropDownXPath)).Click();
                    break;
                    default: throw new NotImplementedException();
            }
        }

        public bool IsPageWithSelectedLanguageIsOpened(Languages languages)
        {
            switch (languages)
            {
                case Languages.ENGLISH:
                    return Driver.FindElement(By.XPath(_enLanguageIconXPath)).Displayed;
                case Languages.РУССКИЙ:
                    return Driver.FindElement(By.XPath(_ruLanguageIconXPath)).Displayed;
                case Languages.УКРАЇНСЬКА:
                    return Driver.FindElement(By.XPath(_uaLanguageIconXPath)).Displayed;
                default: throw new NotImplementedException();
            }
        }



    }
    public enum Languages
    {
        ENGLISH,
        РУССКИЙ,
        УКРАЇНСЬКА,
    }
}
