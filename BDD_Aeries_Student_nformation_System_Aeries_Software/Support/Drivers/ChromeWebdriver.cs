using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers
{
    internal static class ChromeWebdriver
    {
        internal static IWebDriver LoadChromeDriver()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            var driver = new ChromeDriver(driverService, options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            return driver;
        }
    }
}
