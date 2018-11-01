using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTest.model
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(Browser.Driver, page);

            return page;
        }




        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static EmployeeRecordsPage EmployeeRecords
        {
            get { return GetPage<EmployeeRecordsPage>(); }
        }

        public static DashboardPage Dashboard
        {
            get { return GetPage<DashboardPage>(); }
        }

    }
}

