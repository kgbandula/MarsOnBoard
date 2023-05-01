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
    public class EducationPage
    {
        public void AddEducation(IWebDriver driver)
        {
            //select education tab
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
            
            //Click on Add New
            IWebElement educationAddNew = driver.FindElement(By.XPath("//div[@data-tab='third']//div[@class='ui teal button ']"));
            educationAddNew.Click();
            
            //Enter Institute
            IWebElement educationInstitute = driver.FindElement(By.XPath("//input[@placeholder='College/University Name'and @name='instituteName']"));
            educationInstitute.Click();
            educationInstitute.SendKeys("SLIIT");

            //Select country of college            
            var countryInstitute = driver.FindElement(By.Name("country"));
            countryInstitute.Click();
            var selectedCountry = new SelectElement(countryInstitute);
            selectedCountry.SelectByText("Sri Lanka");
                        
            //Select Title            
            var titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            var selectTitle = new SelectElement(titleDropdown);
            selectTitle.SelectByValue("M.A");            
            
            //Enter degree
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            degreeTextbox.Click();
            degreeTextbox.SendKeys("Information Systems");

            //Select year of graduation            
            var graduationDropDown = driver.FindElement(By.Name("yearOfGraduation"));
            graduationDropDown.Click();
            var graduationYear = new SelectElement(graduationDropDown);
            graduationYear.SelectByValue("2010");
           
            //Add education
            IWebElement addEducationButton = driver.FindElement(By.XPath("//input[@type='button' and@class='ui teal button 'and@value='Add']"));
            addEducationButton.Click();
            Thread.Sleep(2000);

            IWebElement degreeTitle = driver.FindElement(By.XPath("//td[text()='Information Systems']"));
            Assert.That(degreeTitle.Text == "Information Systems", "Education added successfully.");
        }
        public void UpdateEducation(IWebDriver driver)
        {
            //select education tab
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
            Thread.Sleep(2000);

            //click on update icon
            IWebElement educationUpdate = driver.FindElement(By.XPath("(//i[@class='outline write icon'])[2]"));
            educationUpdate.Click();
            Thread.Sleep(2000);
            
            //Enter education institute
            IWebElement educationInstitute = driver.FindElement(By.XPath("//input[@placeholder='College/University Name'and @name='instituteName']"));
            educationInstitute.Click();
            educationInstitute.Clear();
            educationInstitute.SendKeys("University of Colombo");

            //Select country of college            
            var updateCountry = driver.FindElement(By.Name("country"));
            updateCountry.Click();
            var updatedCountry = new SelectElement(updateCountry);
            updatedCountry.SelectByText("Sri Lanka");

            //Select Title            
            var updateTitleDropdown = driver.FindElement(By.Name("title"));
            updateTitleDropdown.Click();
            var updatedTitle = new SelectElement(updateTitleDropdown);
            updatedTitle.SelectByValue("M.A");

            //Enter degree
            IWebElement degreeTextbox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            degreeTextbox.Click();
            degreeTextbox.Clear();
            degreeTextbox.SendKeys("Education");

            //Select year of graduation            
            var updateGraduationDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            updateGraduationDropdown.Click();
            var updateGraduationYear = new SelectElement(updateGraduationDropdown);
            updateGraduationYear.SelectByValue("2004");

            //Add education
            IWebElement updateEducationButton = driver.FindElement(By.XPath("//input[@type='button' and@class='ui teal button'and@value='Update']"));
            updateEducationButton.Click();            
            Thread.Sleep(2000);
            
            //Assertion
            IWebElement updatedDegree = driver.FindElement(By.XPath("//td[text()='Education']"));
            Assert.That(updatedDegree.Text == "Education", "Education updated successfully.");
        }
        public void RemoveEducation(IWebDriver driver)
        {
            //select education tab
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
            Thread.Sleep(2000);

            IWebElement recordToBeRemoved = driver.FindElement(By.XPath("//td[text()='Education']"));
            if(recordToBeRemoved.Text == "Education")
            {
                //Remove education
                IWebElement removeEducationButton = driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));
                removeEducationButton.Click();
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record to be deleted can not find.");
            }
        }
    }
}
