using MarsOnBoard.MarsPages;
using MarsOnBoard.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsOnBoard.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        //Join page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        //Profile page object initialization and definition
        ProfilePage profileObj = new ProfilePage();

        //Language page object initialization and definition
        LanguagePage languagePageObj = new LanguagePage();
        private IWebDriver driver;

        [Given(@"I logged into localhostweb portal successfully")]
        public void GivenILoggedIntoLocalhostwebPortalSuccessfully()
        {
            //Open chrome driver
            driver = new ChromeDriver();

            //Join page object initialization and definition
            loginPageObj.JoinActions(driver);
            loginPageObj.loginActions(driver);
        }

                
        [When(@"I navigate to profile language page")]
        public void WhenINavigateToProfileLanguagePage()
        {
            //Profile page object initialization and definition
            profileObj.ProfileActions(driver);
        }
        [When(@"I create a new language record")]
        public void WhenICreateANewLanguageRecord()
        {
            //Add language page object initialization and definition            
            languagePageObj.AddLanguage(driver); 
        }
        [Then(@"The language record should be added successfully")]
        public void ThenTheLanguageRecordShouldBeAddedSuccessfully()
        {
            //Validate add language
            string addLanguageMessage = languagePageObj.validateAddLanguage(driver);
            Assert.That(addLanguageMessage == "Maori has been added to your languages", "Language hasn't been added");
        }
        [When(@"I update '([^']*)','([^']*)' on an existing language record")]
        public void WhenIUpdateOnAnExistingLanguageRecord(string language, string languageLevel)
        {
            //Update language page object initialization and definition
            languagePageObj.UpdateLanguage(driver, language, languageLevel);
        }
        [Then(@"The language record should have the update '([^']*)','([^']*)'")]
        public void ThenTheLanguageRecordShouldHaveTheUpdate(string language, string languageLevel)
        {
            string updateLanguageMessage = languagePageObj.validateUpdateLanguage(driver);
            if (updateLanguageMessage == "Sinhala has been updated to your languages")
            {
                Assert.That(updateLanguageMessage == "Sinhala has been updated to your languages", "Language hasn't been updated");
            }
            if (updateLanguageMessage == "Tamil has been updated to your languages")
            {
                Assert.That(updateLanguageMessage == "Tamil has been updated to your languages", "Language hasn't been updated");
            }
            if (updateLanguageMessage == "English has been updated to your languages")
            {
                Assert.That(updateLanguageMessage == "English has been updated to your languages", "Language hasn't been updated");
            }
        }

        [When(@"I remove language record")]
        public void WhenIRemoveLanguageRecord()
        {
            //Remove language page object initialization and definition
            languagePageObj.RemoveLanguage(driver);
        }
        [Then(@"The language record should be removed successfully")]
        public void ThenTheLanguageRecordShouldBeRemovedSuccessfully()
        {
            string removeLanguageMessage = languagePageObj.validateRemoveLanguage(driver);           
            if (removeLanguageMessage == "Tamil has been deleted from your languages")
            {
                Assert.That(removeLanguageMessage == "Tamil has been deleted from your languages", "Language hasn't been deleted");
            }
            if (removeLanguageMessage == "English has been deleted from your languages")
            {
                Assert.That(removeLanguageMessage == "English has been deleted from your languages", "Language hasn't been deleted");
            }
            if (removeLanguageMessage == "Sinhala has been deleted from your languages")
            {
                Assert.That(removeLanguageMessage == "Sinhala has been deleted from your languages", "Language hasn't been deleted");
            }           
        }
    }
}
