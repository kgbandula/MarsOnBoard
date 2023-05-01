using MarsOnBoard.MarsPages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsOnBoard.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [SetUp]
        public void JoinSteps()
        {
            driver = new ChromeDriver();
            //Join page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.JoinActions(driver);
        }
        [SetUp]
        public void LoginSteps()
        {
            //Join page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginActions(driver);
        }
        [SetUp]
        public void ProfileSteps()
        {
            //Profile page object initialization and definition
            ProfilePage profileObj = new ProfilePage();
            profileObj.ProfileActions(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Close();
        }
    }
}
