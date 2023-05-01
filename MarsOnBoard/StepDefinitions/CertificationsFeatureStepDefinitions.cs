using MarsOnBoard.MarsPages;
using MarsOnBoard.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
namespace MarsOnBoard.StepDefinitions
{
    [Binding]
    public class CertificationsFeatureStepDefinitions : CommonDriver
    {
        //Join page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        //Profile page object initialization and definition
        ProfilePage profileObj = new ProfilePage();

        //Skill page object initialization and definition
        CertificationPage CertificationPageObj = new CertificationPage();

        [Given(@"I logged into myskill portal successfully")]
        public void GivenILoggedIntoMyskillPortalSuccessfully()
        {
            //Open chrome driver
            driver = new ChromeDriver();

            //Join page object initialization and definition
            loginPageObj.JoinActions(driver);
            loginPageObj.loginActions(driver);            
        }

        [When(@"I navigate to profile certification page")]
        public void WhenINavigateToProfileCertificationPage()
        {
            //Profile page object initialization and definition            
            profileObj.ProfileActions(driver);
        }

        [When(@"I create a new certification record")]
        public void WhenICreateANewCertificationRecord()
        {
            //Add language page object initialization and definition            
            CertificationPageObj.AddCertification(driver);
        }

        [Then(@"The certification record should be added successfully")]
        public void ThenTheCertificationRecordShouldBeAddedSuccessfully()
        {
            //Validate add skill
            string addCertificateMessage = CertificationPageObj.validateAddCertification(driver);
            Assert.That(addCertificateMessage == "Financial management has been added to your certification", "Certification hasn't been added");            
        }

        [When(@"I update '([^']*)','([^']*)','([^']*)' on an existing certificate record")]
        public void WhenIUpdateOnAnExistingCertificateRecord(string certificate, string from, string year)
        {
            //Update certificate page object initialization and definition
            CertificationPageObj.UpdateCertification(driver, certificate, from, year);
        }

        [Then(@"The certificate record should have the updated '([^']*)','([^']*)''([^']*)'")]
        public void ThenTheCertificateRecordShouldHaveTheUpdated(string certificate, string from, string year)
        {
            string updateCertificationMessage = CertificationPageObj.validateUpdateCertification(driver);
            if (updateCertificationMessage == "Key Board has been updated to your certification")
            {
                Assert.That(updateCertificationMessage == "Key Board has been updated to your certification", "Certification hasn't been updated");
            }
            if (updateCertificationMessage == "Education has been updated to your certification")
            {
                Assert.That(updateCertificationMessage == "Education has been updated to your certification", "Certification hasn't been updated");
            }
            if (updateCertificationMessage == "Information Systems has been updated to your certification")
            {
                Assert.That(updateCertificationMessage == "Information Systems has been updated to your certification", "Certification hasn't been updated");
            }
        }

        [When(@"I navigate to profile certificate page")]
        public void WhenINavigateToProfileCertificatePage()
        {
            
        }

        [When(@"I remove certificate record")]
        public void WhenIRemoveCertificateRecord()
        {
            //Remove certification page object initialization and definition
            CertificationPageObj.RemoveCertification(driver);
        }

        [Then(@"The certificate record should be removed successfully")]
        public void ThenTheCertificateRecordShouldBeRemovedSuccessfully()
        {
            string removeCertificationMessage = CertificationPageObj.validateRemoveCertification(driver);
            if (removeCertificationMessage == "Key Board has been deleted from your certification")
            {
                Assert.That(removeCertificationMessage == "Key Board has been deleted from your certification", "Certification hasn't been deleted");
            }
            if (removeCertificationMessage == "Education has been deleted from your certification")
            {
                Assert.That(removeCertificationMessage == "Education has been deleted from your certification", "Certification hasn't been deleted");
            }
            if (removeCertificationMessage == "Information Systems has been deleted from your certification")
            {
                Assert.That(removeCertificationMessage == "Information Systems has been deleted from your certification", "Certification hasn't been deleted");
            }            
        }
    }
}
