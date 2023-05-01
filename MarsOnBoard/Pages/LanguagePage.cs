using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnBoard.MarsPages
{
    public class LanguagePage
    {
        public void AddLanguage(IWebDriver driver)
        {
            //select languages tab
            IWebElement languagesTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagesTab.Click();

            //click on add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            //add language
            IWebElement addLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            addLanguage.Click();
            addLanguage.SendKeys("Maori");

            //select language level (basic, conversational, fluent and native/bilingual
            var languageLevel = driver.FindElement(By.Name("level"));
            languageLevel.Click();
            var levelSelection = new SelectElement(languageLevel);
            levelSelection.SelectByValue("Fluent");
            
            //Add language            
            IWebElement languageAddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            languageAddButton.Click();
            Thread.Sleep(2000);
        }

        public string validateAddLanguage(IWebDriver driver)
        {
            //IWebElement addSkillMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));
            IWebElement addLanguageMessage = driver.FindElement(By.XPath("//*[contains(text(),'has been added to your languages')]"));
            return addLanguageMessage.Text;
        }
        public void UpdateLanguage(IWebDriver driver, string language, string languageLevel)
        {
            //select languages tab
            IWebElement languagesTab = driver.FindElement(By.XPath("//a[text()='Languages']"));
            languagesTab.Click();
            Thread.Sleep(2000);

            //edit language  
            IWebElement languageEditIcon = driver.FindElement(By.XPath("((//i[@class='outline write icon'])[2])"));
            languageEditIcon.Click();

            //click language button
            IWebElement languageUpdateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            languageUpdateButton.Click();
            IWebElement languageEditTextbox = driver.FindElement(By.Name("name"));
            languageEditTextbox.Click();
            languageEditTextbox.Clear();
            languageEditTextbox.SendKeys(language);

            //edit language level(basic, conversational, fluent and native/bilingual)
            var updateLanguage = driver.FindElement(By.Name("level"));
            updateLanguage.Click();
            var updatedLangugage = new SelectElement(updateLanguage);
            updatedLangugage.SelectByValue(languageLevel);
            
            //Update language
            IWebElement editUpdateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            editUpdateButton.Click();
            Thread.Sleep(2000);                      
        }
        public string validateUpdateLanguage(IWebDriver driver)
        {
            IWebElement updateLanguageMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));
            return updateLanguageMessage.Text;
        }
        public void RemoveLanguage(IWebDriver driver)
        {
            //select languages tab
            IWebElement languagesTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languagesTab.Click();
            Thread.Sleep(2000);

            //Remove language
            IWebElement removeIcon = driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));
            removeIcon.Click();
            Thread.Sleep(2000);            
        }
        public string validateRemoveLanguage(IWebDriver driver)
        {
            //IWebElement removeLanguageMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div')]"));
            IWebElement removeLanguageMessage = driver.FindElement(By.XPath("//*[contains(text(),'has been deleted from your languages')]"));
            return removeLanguageMessage.Text; 
        }

    }
}