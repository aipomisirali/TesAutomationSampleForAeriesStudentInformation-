using System;
using BDD_Aeries_Student_nformation_System_Aeries_Software.Pages;
using BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers;
using BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.StepDefinitions
{
    [Binding]
    public class About_US_PageDetails_Steps:Page
    {
       


        public About_US_PageDetails_Steps(BrowserDriver driverHelper)
        {
          //  _driverHelper = driverHelper;
          //  homePage = new HomePage(_driverHelper.Driver);
        }




        [Given(@"User Navigates to (.*)")]
        public void GivenUserNavigatesTo(string uRL)
        {

            InstanceOf<BasePage>().NavigateToURL(uRL);

            InstanceOf<BasePage>().ValidatePageTitle("Aeries Student Information System - Aeries Software");

    

  

        }


        [When(@"User Clicks About ""(.*)""")]
        public void WhenUserClicksAbout(string p0) {

           
            InstanceOf<BasePage>().AboutClick();


            }

            [Then(@"Verify user redirected for the following (.*)")]
            public void ThenVerifyUserRedirectedForTheFollowing(string textTitle)
            {
          string ActualAboutUsTitle=  InstanceOf<BasePage>().AboutUsTitle.Text;

            Assert.AreEqual(textTitle, ActualAboutUsTitle);
            }

        

        
    } }

