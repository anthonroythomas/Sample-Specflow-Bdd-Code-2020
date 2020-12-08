using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebTestProject.Pages;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace WebTestProject.Steps
{
    [Binding]
    public sealed class CreateNewTimesheet
       
    {
        //no context injection hack (quick hack for this assessment)
        CreatePage createPage = null;
        HomePage homePage = null;


        [Given(@"the user is on the home page")]
        public void GivenTheUserIsOnTheHomePage()
        {
            //Obviously not best practice, would need abstracting out in a proper framework
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://codat-qa-task.azurewebsites.net/");
            homePage = new HomePage(webDriver);
            createPage = new CreatePage(webDriver); 
        }


        [Given(@"the Create New button is pressed")]
        public void GivenTheCreateNewButtonIsPressed()
        {
            homePage.ClickCreateNew();
        }

        [Given(@"the user is navigated to Create or Edit Page")]
        public void GivenTheUserIsNavigatedToCreateOrEditPage()
        {
            String text = createPage.getTimesheetHeader();
            Console.WriteLine(text);
            text.Equals("Timesheet");
        }

        [Given(@"the user enters a valid Emplyee ID")]
        public void GivenTheUserEntersAValidEmplyeeID()
        {
            createPage.setEmployeeID("CT0099"); //To Do: randominse the last 3 digits for better flexibility
        }

        [Given(@"the user enters a valid Houry Rate")]
        public void GivenTheUserEntersAValidHouryRate()
        {
            createPage.setHourlyRate("20");
        }

        [Given(@"the user selects a Day")]
        public void GivenTheUserSelectsADay()
        {
            createPage.setDayDropdown("Sunday");
        }

        [Given(@"the user Selects Hours")]
        public void GivenTheUserSelectsHours()
        {
            createPage.setHours("30");
        }

        [Given(@"the user Selects Minutes")]
        public void GivenTheUserSelectsMinutes()
        {
            createPage.setMins("55");
        }



        [Given(@"the user submits the time")]
        public void WhenTheUserSubmitsTheTime()
        {
            //Sorry, bad I know, but it's late and I need sleep.
           //System.Threading.Thread.Sleep(4000);
            createPage.clickAddRow();
        }

        [When(@"the user clicks the Save button")]
        public void WhenTheUserClicksTheSaveButton()
        {
          createPage.clickSave();
        }

        [Then(@"the user is taken to a valid summary page")]
        public void ThenTheUserIsTakenToAValidSummaryPage()
        {
            String CurrUrl = createPage.GetCurrentUrl();
           
            Assert.That(CurrUrl.Contains("https://codat-qa-task.azurewebsites.net/Details?timesheetId="));

           bool test = createPage.IsElementPresent(By.XPath("//table[@class = 'table']"));
           Console.WriteLine(test);
           Assert.That(test.Equals(true) );
        }



        }


    }

