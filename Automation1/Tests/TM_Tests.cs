using Automation1.Pages;
using Automation1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.Tests
{

    [TestFixture]
    class TM_Tests : CommonDriver
    {
    

      

        [Test, Order(1), Description("Check if user is able to create a Time record with valid data")]
        public void CreateTMTest()
        {

            HomePage homePageObj = new HomePage();
            homePageObj.GotoTMPage(driver);

            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

        }

        [Test, Order(2), Description("Check if user is able to edit the created Time record with valid data")]
        public void EditTMTest()
        {

          

            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);

        }

        [Test, Order(3), Description("Check if user is able to delete Time record")]
        public void DeleteTMTest()
        {

          

            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);

        }

      

    }
}



