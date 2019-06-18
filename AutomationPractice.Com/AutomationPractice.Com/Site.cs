using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace AutomationPractice.Com
{
    public class Site
    {
        public void InitialiseChromeDriver()
        {
            Driver._webDriver = new ChromeDriver();
            Driver._webDriver.Navigate().GoToUrl(Config.SiteToTest);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
        }



    }
}
