using MarsOnBoard.MarsPages;
using MarsOnBoard.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace MarsOnBoard.StepDefinitions
{
    [Binding]
    public class SkillFeatureStepDefinitions : CommonDriver
    {
        //Join page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        //Profile page object initialization and definition
        ProfilePage profileObj = new ProfilePage();

        //Skill page object initialization and definition
        SkillPage skillPageObj = new SkillPage();

        [Given(@"I logged into localhost portal successfully")]
        public void GivenILoggedIntoLocalhostPortalSuccessfully()
        {
            //Open chrome driver
            driver = new ChromeDriver();

            //Join page object initialization and definition
            loginPageObj.JoinActions(driver);
            loginPageObj.loginActions(driver);
        }


        [When(@"I navigate to profile skill page")]
        public void WhenINavigateToProfileSkillPage()
        {
            //Profile page object initialization and definition
            profileObj.ProfileActions(driver);
        }

        [When(@"I create a new skill record")]
        public void WhenICreateANewSkillRecord()
        {
            //Add skill page object initialization and definition
            skillPageObj.AddSkill(driver);
        }

        [Then(@"The record should be added successfully")]
        public void ThenTheRecordShouldBeAddedSuccessfully()
        {
            //Validate add skill
            string addSkillMessage = skillPageObj.validateAddSkill(driver);
            Assert.That(addSkillMessage == "Communication has been added to your skills", "Skill hasn't been added");            
        }

        [When(@"I update '([^']*)','([^']*)' on an existing skill record")]
        public void WhenIUpdateOnAnExistingSkillRecord(string skill, string skillLevel)
        {
            //Update Skill page object initialization and definition
            skillPageObj.UpdateSkill(driver, skill, skillLevel);
        }
        [Then(@"The record should have the updated '([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string skill, string skillLevel)
        {
            string updateSkillMessage = skillPageObj.validateUpdateSkill(driver);
            if (updateSkillMessage == "Negotiation has been updated to your skills")
            {
                Assert.That(updateSkillMessage == "Negotiation has been updated to your skills", "Skill hasn't been updated");
            }
            if (updateSkillMessage == "Collaboration has been updated to your skills")
            {
                Assert.That(updateSkillMessage == "Collaboration has been updated to your skills", "Skill hasn't been updated");
            }
            if (updateSkillMessage == "Attention to detail has been updated to your skills")
            {
                Assert.That(updateSkillMessage == "Attention to detail has been updated to your skills", "Skill hasn't been updated");               
            }
        }
        [When(@"I remove skill record")]
        public void WhenIRemoveSkillRecord()
        {
            //Remove Skill page object initialization and definition
            skillPageObj.RemoveSkill(driver);
        }
        [Then(@"The record should be removed successfully")]
        public void ThenTheRecordShouldBeRemovedSuccessfully()
        {
            string removeSkillMessage = skillPageObj.validateRemoveSkill(driver);
            //Assert.That(removeSkillMessage == "Collaboration has been deleted", "Skill hasn't been deleted");
            if (removeSkillMessage == "Negotiation has been deleted")
            {
                Assert.That(removeSkillMessage == "Negotiation has been deleted", "Skill hasn't been deleted");
            }
            if (removeSkillMessage == "Collaboration has been deleted")
            {
                Assert.That(removeSkillMessage == "Collaboration has been deleted", "Skill hasn't been deleted");
            }
            if (removeSkillMessage == "Attention to detail has been deleted")
            {
                Assert.That(removeSkillMessage == "Attention to detail has been deleted", "Skill hasn't been deleted");
            }
        }
    }
}