using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Automation1
{
    class Program
    {
        static void Main(string[] args)
        {

            //open chrome browser
            IWebDriver driver = new ChromeDriver();
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

            //IWebElement DashboardButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[1]/a"));
            // DashboardButton.Click();
            // IWebElement HideButton = driver.FindElement(By.XPath("//*[@id='eventbutton']"));
            // HideButton.Click();

            //Find administration  and click on it
            IWebElement Administration = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            Administration.Click();

            //Find TMDropdown and click on it
            IWebElement TMDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMDropdown.Click();

            //Find Createnewbutton and click on it
            IWebElement CreateNewtextbox = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewtextbox.Click();

            //Find typecodetextbox dropdown
            IWebElement Typecodetextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]"));
            Typecodetextbox.Click();

            //find Material and click on it
            IWebElement Materialdropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            Materialdropdown.Click();

            //find code textbox and enter a value
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys("wire");

            //find textbox Description and enter a value
            IWebElement Descriptiontextbox = driver.FindElement(By.Id("Description"));
            Descriptiontextbox.SendKeys("tuhjjkk");

            //find textbox priceperunit and enter a value
            IWebElement PriceperUnittextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PriceperUnittextbox.SendKeys("9");

            //click save button

            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(2000);

            //find lastpagebutton and click on it
            IWebElement gotoLastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotoLastpageButton.Click();
            Thread.Sleep(2000);


            IWebElement Actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));



            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            EditButton.Click();
            Thread.Sleep(2000);

            IWebElement EditPriceperUnittextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));

            EditPriceperUnittextbox.SendKeys("9");



           IWebElement EditSaveButton = driver.FindElement(By.Id("SaveButton"));
            EditSaveButton.Click();
            Thread.Sleep(2000);



            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            DeleteButton.Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Deleted item sucessfully");



        }
    }
}
