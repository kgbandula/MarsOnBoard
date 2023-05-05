using MarsOnBoard.Utilities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
    public class SkillPage
    {
       public void AddSkill(IWebDriver driver)
        {
            //select skills tab
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
            
            //click skills AddNew
            IWebElement skillsAddNew = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            skillsAddNew.Click();
            
            //Add a skill
            IWebElement skillsAddSkillsTB = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            skillsAddSkillsTB.Click();
            skillsAddSkillsTB.SendKeys("Communication");

            //Select skill level Begginer, Intermediate, Expert
            var skillLevelDropDown = driver.FindElement(By.XPath("//*[@name='level']"));
            skillLevelDropDown.Click();
            var addSkillLevel = new SelectElement(skillLevelDropDown);
            addSkillLevel.SelectByValue("Beginner");                 
            
            //Add skill
            IWebElement addSkillButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            addSkillButton.Click();
            Thread.Sleep(2000);
            
        }
        //Validate if skill details added to skill page
        public string validateAddSkill(IWebDriver driver)
        {
            //IWebElement addSkillMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));
            IWebElement addSkillMessage = driver.FindElement(By.XPath("//*[contains(text(),'has been added to your skills')]"));
            return addSkillMessage.Text;
        }
        
        public void UpdateSkill(IWebDriver driver, string skill, string skillLevel)
        {
            //select skills tab
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
            Thread.Sleep(3000);

            //click skills AddNew
            IWebElement skillsUpdateIcon = driver.FindElement(By.XPath("//tr//span[i[@class='outline write icon']]"));
            skillsUpdateIcon.Click();
            Thread.Sleep(2000);
            
            //Add a skill
            IWebElement updateSkill = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
            updateSkill.Click();
            updateSkill.Clear();
            updateSkill.SendKeys(skill);

            //Select skill level
            var updateSkillLevel = driver.FindElement(By.Name("level"));
            updateSkillLevel.Click();
            var updatedSkill = new SelectElement(updateSkillLevel);
            updatedSkill.SelectByValue(skillLevel);

            //Update skill
            IWebElement updateSkillButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateSkillButton.Click();
            Thread.Sleep(2000);           
        }
        public string validateUpdateSkill(IWebDriver driver)
        {            
            IWebElement updateSkillMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));
            return updateSkillMessage.Text;
        }
        
        public void RemoveSkill(IWebDriver driver) 
        {
            //select skills tab
            IWebElement skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillsTab.Click();
            Thread.Sleep(2000);

            //Delete a skill
            IWebElement removeSkillIcon = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            removeSkillIcon.Click();
            Thread.Sleep(2000);
        }
        public string validateRemoveSkill(IWebDriver driver)
        {
            //IWebElement removeSkillMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div"));
            IWebElement removeSkillMessage = driver.FindElement(By.XPath("//*[contains(text(),'has been deleted')]"));
            return removeSkillMessage.Text;
        }       
    }
}
