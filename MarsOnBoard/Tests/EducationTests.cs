using MarsOnBoard.MarsPages;
using MarsOnBoard.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnBoard.Tests
{
    [TestFixture,Order(3)]
    //[Parallelizable]
    public class EducationTests : CommonDriver
    {
        //Education page object initialization and definition
        EducationPage educationPageObj = new EducationPage();
        [Test, Order(1)]
        public void EducationAddSteps()
        {
            ////Add education page object initialization and definition            
            //educationPageObj.AddEducation(driver);
        }
        [Test, Order(2)]
        public void EducationUpdateSteps()
        {
            ////Update education page object initialization and definition            
            //educationPageObj.UpdateEducation(driver);
        }
        [Test, Order(3)]
        public void EducationRemoveSteps()
        {
            ////Remove education page object initialization and definition            
            //educationPageObj.RemoveEducation(driver);
        }        
    }
}
