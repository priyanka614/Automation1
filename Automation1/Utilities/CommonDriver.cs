using Automation1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            //driver.Quit();
        }


    }

}

