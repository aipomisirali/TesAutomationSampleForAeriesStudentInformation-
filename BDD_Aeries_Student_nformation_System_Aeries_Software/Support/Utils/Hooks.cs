using System;
using BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Utils
{
    [Binding]
    internal static class Hooks
    {
        [BeforeScenario]
        internal static void StartWebDriver()
        {
            
                DriverController.Instance.StartChrome();

        }
   

        [AfterScenario]
        internal static void StopWebDriver()
        {
            DriverController.Instance.StopWebDriver();
        }
    }
    }