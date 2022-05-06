using System;
using OpenQA.Selenium;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers
{
    internal class DriverController
    {
        internal static DriverController Instance = new DriverController();
        internal IWebDriver WebDriver { get; set; }

        internal void StartChrome()
        {

            if (WebDriver != null) return;
            WebDriver = ChromeWebdriver.LoadChromeDriver();

        }


        internal void StopWebDriver()
        {
            if (WebDriver == null) return;

            try
            {

                WebDriver.Quit();


                WebDriver.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(":: Webdriver stop error" + e);
            }



        }
    }
}
