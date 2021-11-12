using Automation1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.Pages
{
    class LoginPage : CommonDriver
    {
        public  void LoginSteps(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();


            //Launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //find  textbox username and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //find  textbox password and enter valid password
            IWebElement PasswdTextbox = driver.FindElement(By.Id("Password"));
            PasswdTextbox.SendKeys("123123");

            //Identify and click on login button 
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //check if user has  logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }
        }
    }
}

