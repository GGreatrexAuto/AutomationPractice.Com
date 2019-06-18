using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace AutomationPractice.Com
{
    public static class Driver
    {
        public static IWebDriver _webDriver;
        
        public static void WaitForUpTo(int seconds)
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        
    }
}
