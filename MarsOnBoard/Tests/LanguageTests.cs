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
    [TestFixture, Order(1)]
    //[Parallelizable]
    public class LanguageTests : CommonDriver
    {
        //Language page object initialization and definition
        LanguagePage languagePageObj = new LanguagePage();
        [Test, Order(1)]
        public void LanguageAddSteps() 
        {
            ////Add language page object initialization and definition            
            //languagePageObj.AddLanguage(driver);
        }
        [Test, Order(2)]
        public void LanguageUpdateSteps()
        {
            ////Update language page object initialization and definition
            //languagePageObj.UpdateLanguage(driver);
        }
        [Test, Order(3)]
        public void LanguageRemoveSteps()
        {
            ////Remove language page object initialization and definition            
            //languagePageObj.RemoveLanguage(driver);
        }
    }
}
