using MarsOnBoard.MarsPages;
using MarsOnBoard.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnBoard.Tests
{
    [TestFixture,Order(4)]
    //[Parallelizable]
    public class CertificationTests : CommonDriver
    {
        //Certification page object initialization and definition
        CertificationPage certificationPageObj = new CertificationPage();

        [Test,Order (1)]
        public void CertificationAddSteps()
        {
            ////Add certification page object initialization and definition
            //certificationPageObj.AddCertification(driver);
        }
        [Test, Order(2)]
        public void CertificationUpdateSteps()
        {
            ////Update certification page object initialization and definition            
            //certificationPageObj.UpdateCertification(driver);
        }
        [Test, Order(3)]
        public void CertificationRemoveSteps()
        {
            ////Remove certification page object initialization and definition            
            //certificationPageObj.RemoveCertificaton(driver);
        }        
    }
}
