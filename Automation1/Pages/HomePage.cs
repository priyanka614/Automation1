using Automation1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.Pages
{
    class HomePage : CommonDriver
    {

       public  void GotoTMPage(IWebDriver driver)
        {
            //Find administration  and click on it
            IWebElement Administration = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            Administration.Click();

            Wait.WaitforWebElementIsVisible(driver, "XPath", "/ html / body / div[3] / div / div / ul / li[5] / a", 3);

            //Find TMDropdown and click on it
            IWebElement TMDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TMDropdown.Click();

        }
    }
}