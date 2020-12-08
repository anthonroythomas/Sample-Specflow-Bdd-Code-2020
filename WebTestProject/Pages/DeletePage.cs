using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebTestProject.Pages
{
    public class DeletePage
    {

        public IWebDriver WebDriver { get; }

        public DeletePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement btnBackToList => WebDriver.FindElement(By.LinkText("Back to List"));

        public IWebElement txtTimesheetID => WebDriver.FindElement(By.XPath("//main/div/h4"));


    }
}
