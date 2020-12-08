using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using WebTestProject.Pages;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace WebTestProject.Pages
{
    public class CreatePage
    {

        public IWebDriver WebDriver { get; }

        public CreatePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }


        public String TimesheetHeader => WebDriver.FindElement(By.XPath("//div/main/h4")).Text; //Dont love the use of Xpaths, but for quick tests, these relative Xpaths work OK

        public IWebElement txtInputEmployeeID() => WebDriver.FindElement(By.Id("Timesheet_EmployeeId"));

        public IWebElement txtInputHourlyRate() => WebDriver.FindElement(By.Id("Timesheet_HourlyRate"));

        public IWebElement dayDropdown() => WebDriver.FindElement(By.Id("newEntry_Day"));

        public SelectElement daySelect() => new SelectElement(WebDriver.FindElement(By.Id("newEntry_Day")));

        public IWebElement txtInputSetHours() => WebDriver.FindElement(By.Id("newEntry_Hours"));

        public IWebElement txtInputSetMins() => WebDriver.FindElement(By.Id("newEntry_Minutes"));

        public IWebElement btnSave() => WebDriver.FindElement(By.XPath("//input[@value = 'Save']"));

        public IWebElement btnAddRow() => WebDriver.FindElement(By.Id("add-row"));


        bool isSummaryDisplayed() => WebDriver.FindElement(By.XPath("//table[@class = 'table']")).Displayed;

        public String getTimesheetHeader()
        {
            return TimesheetHeader;
        }

        public void setEmployeeID(string input)
        {
            txtInputEmployeeID().Click();
            txtInputEmployeeID().SendKeys(input);
        }

        public void setHourlyRate(string input)
        {
            txtInputHourlyRate().Click();
            txtInputHourlyRate().SendKeys(input);
        }


        public void setDayDropdown(string input)
        {
            daySelect().SelectByText(input);

        }

        public void setHours(string input)
        {
            txtInputSetHours().Click();
            txtInputSetHours().SendKeys(input);

        }

        public void setMins(string input)
        {
            txtInputSetMins().Click();
            txtInputSetMins().SendKeys(input);

        }

        public void clickSave()
        {
            btnSave().Click();

        }

        public string GetCurrentUrl()
        {
            String url = WebDriver.Url;
            return url;
        }

        public bool IsSummaryPresent()
        {
            return isSummaryDisplayed();
        }
        public bool IsElementPresent(By by)
        {
            try
            {
                WebDriver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void clickAddRow()
        {
            //WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            //var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-row")));

            //Actions action = new Actions(WebDriver);
            //action.MoveToElement(element).Click().Build().Perform();


            btnAddRow().Click();

        }
        
    }
    }

