using System;
using BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers;
using BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Pages
{
    public class HomePage:Page
    {
        BrowserDriver driver2;

        IWebDriver driver;


       // WebDriverHelper wdExtention= new WebDriverHelper(driver2.Driver);

        public HomePage(IWebDriver driverHelper)
        {
            this.driver = driverHelper;

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        IWebElement AboutUs => driver.FindElement(By.XPath("//text()[. ='About Us']"));




        public void ClickAboutUs() {


           // wdExtention.dcrollDown();

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            AboutUs.Click(); }


    }


   



}

 

