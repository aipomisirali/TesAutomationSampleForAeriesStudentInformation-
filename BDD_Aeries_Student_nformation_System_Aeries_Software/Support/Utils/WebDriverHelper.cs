using System;
using BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers;
using OpenQA.Selenium;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Utils
{
    public class WebDriverHelper:Pages.Page
    {
        public static IWebDriver Driver { get; internal set; }



        public static  void scrollDown()
        {



            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("window.scrollBy(0,250)", "");
            }
        }
    }

       