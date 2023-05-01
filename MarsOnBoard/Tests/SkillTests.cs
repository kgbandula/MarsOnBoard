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
    [TestFixture,Order(2)]
    //[Parallelizable]
    public class SkillTests : CommonDriver
    {
        //Skill page object initialization and definition
        SkillPage skillPageObj = new SkillPage();
        [Test, Order(1)]
        public void SkillAddSteps()
        {
            //Add skill page object initialization and definition
            skillPageObj.AddSkill(driver);
        }
        [Test, Order(2)]
        public void SkillUpdateSteps()
        {
            ////Update Skill page object initialization and definition
            //skillPageObj.UpdateSkill(driver);
        }
        [Test, Order(3)]
        public void SkillRemoveSteps()
        {
            //Remove Skill page object initialization and definition            
            skillPageObj.RemoveSkill(driver);
        }       
    }
}
