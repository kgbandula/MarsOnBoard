using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnBoard.MarsPages
{
    public class CertificationPage
    {
        public void AddCertification(IWebDriver driver)
        {
            //select certifications tab
            IWebElement certificationsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsTab.Click();

            //Click add new button
            IWebElement addNewCertification = driver.FindElement(By.XPath("//div[@data-tab='fourth']//div[@class='ui teal button ']"));
            addNewCertification.Click();

            //Enter certification
            IWebElement certificateTextbox = driver.FindElement(By.XPath("//input[@class='certification-award capitalize']"));
            certificateTextbox.Click();
            certificateTextbox.SendKeys("Financial management");

            //Enter institute
            IWebElement certifiedFromTextbox = driver.FindElement(By.XPath("//input[@class='received-from capitalize']"));
            certifiedFromTextbox.Click();
            certifiedFromTextbox.SendKeys("Chartered Institute");

            //Year of certification
            var yearDropDown = driver.FindElement(By.Name("certificationYear"));
            yearDropDown.Click();
            var selectYear = new SelectElement(yearDropDown);
            selectYear.SelectByText("2010");

            //Save certification
            IWebElement addCertification = driver.FindElement(By.XPath("//input[@type='button'and@value='Add'and@class='ui teal button ']"));
            addCertification.Click();
            Thread.Sleep(2000);
        }
        public string validateAddCertification(IWebDriver driver)
        {
            //IWebElement addSkillMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));
            IWebElement addCertificationMessage = driver.FindElement(By.XPath("//*[contains(text(),'has been added to your certification')]"));
            return addCertificationMessage.Text; 
        }
        public void UpdateCertification(IWebDriver driver, string certificate, string from, string year)
        {
            //select certifications tab
            IWebElement certificationsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsTab.Click();
            Thread.Sleep(2000);

            //edit language  
            IWebElement certificateEditIcon = driver.FindElement(By.XPath("(//i[@class='outline write icon'])[2]"));
            certificateEditIcon.Click();

            //Update certification
            IWebElement certificateTextbox2 = driver.FindElement(By.Name("certificationName"));
            certificateTextbox2.Click();
            certificateTextbox2.Clear();
            certificateTextbox2.SendKeys(certificate);

            //Update institute
            IWebElement certifiedFromTextbox2 = driver.FindElement(By.Name("certificationFrom"));
            certifiedFromTextbox2.Click();
            certifiedFromTextbox2.Clear();
            certifiedFromTextbox2.SendKeys(from);

            //Update year
            var yearDropDown = driver.FindElement(By.Name("certificationYear"));
            yearDropDown.Click();
            var updatedYear = new SelectElement(yearDropDown);
            updatedYear.SelectByText(year);

            //Save update
            IWebElement updateCertification = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateCertification.Click();
            Thread.Sleep(2000);
        }
        public string validateUpdateCertification(IWebDriver driver)
        {
            IWebElement updateCertificationMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));
            return updateCertificationMessage.Text;
        }

        public void RemoveCertification(IWebDriver driver)
        {
            //select certifications tab
            IWebElement certificationsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsTab.Click();
            Thread.Sleep(2000);

            //Remove certifications
            IWebElement removeIcon = driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));
            removeIcon.Click();
            Thread.Sleep(2000);
        }
        public string validateRemoveCertification(IWebDriver driver)
        {
            IWebElement removeCertificationMessage = driver.FindElement(By.XPath("//*[contains(text(),'has been deleted from your certification')]"));
            return removeCertificationMessage.Text;               
        }
    }
}
