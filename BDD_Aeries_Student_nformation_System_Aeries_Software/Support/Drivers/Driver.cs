using System;
using OpenQA.Selenium;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers
{
    internal  class Driver
    {
        internal static IWebDriver Browser()
        {
            return DriverController.Instance.WebDriver;
        }

        public static void Test()
        {
            Console.WriteLine("Testing expression body");
        }
    }
}
