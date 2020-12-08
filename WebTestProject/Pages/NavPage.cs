using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebTestProject.Pages
{
    public class NavPage
    {

        public IWebDriver WebDriver { get; }

        public NavPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement lnkHome => WebDriver.FindElement(By.LinkText("Home"));

        public IWebElement lnkInstructions => WebDriver.FindElement(By.LinkText("Instructions"));

        public IWebElement lnkPrivacy => WebDriver.FindElement(By.LinkText("Privacy"));


    }
}
