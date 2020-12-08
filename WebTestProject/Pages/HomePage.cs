using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace WebTestProject.Pages
{
    public class HomePage
    {

        public IWebDriver WebDriver { get; }

        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement btnCreateNew => WebDriver.FindElement(By.XPath("//div/main/p/a"));

        public IWebElement btnDelete => WebDriver.FindElement(By.LinkText("//table/tbody/tr[1]/td[5]/a[3]"));

        public String txtTimesheetID => WebDriver.FindElement(By.XPath("//table/tbody/tr[1]/td[2]")).Text;



        public String getFirstTimesheetID()
        {
            return txtTimesheetID;
        }


        public void ClickCreateNew() => btnCreateNew.Click();

        public void ClickFirstDeleteBtn() => btnDelete.Click();

    }
}
