using System;
using SeleniumExtras.PageObjects;

using BDD_Aeries_Student_nformation_System_Aeries_Software.Support.Drivers;

namespace BDD_Aeries_Student_nformation_System_Aeries_Software.Pages
{
    public abstract class Page
    {
        protected T InstanceOf<T>() where T : BasePage, new()
        {
            var pageClass = new T { Driver = Driver.Browser() };
            PageFactory.InitElements(Driver.Browser(),pageClass);

            return pageClass;

        }
    }
}
