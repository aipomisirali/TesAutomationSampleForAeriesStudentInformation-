using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Pages
{
    public class BasePage : Page
    {
        public IWebDriver Driver { get; internal set; }

        [FindsBy(How = How.LinkText, Using = "about")]
        public IWebElement AbutUs { get; set; }
        

        [FindsBy(How = How.XPath, Using = "//h1[@class='text-title font-aeries font-bold leading-tight tracking-tight md:text-display']")]
        public IWebElement AboutUsTitle{ get; set; }


        public void ValidatePageTitle(string expectedTitle)
        {
            var titleToValidate = Driver.Title.Contains(expectedTitle);

            Assert.IsTrue(titleToValidate);

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
          
            js.ExecuteScript("window.scrollBy(0,6400)");

        }

        public void NavigateToURL(string URL)
        {
            
            Driver.Navigate().GoToUrl(URL);
        }

       public void AboutClick()
        {

            AbutUs.Click();
        }


    }
}
