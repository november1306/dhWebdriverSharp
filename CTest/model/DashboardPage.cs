using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTest.model
{
    public class DashboardPage
    {
        [FindsBy(How = How.Id, Using = "menu_time_viewTimeModule")]
        private IWebElement MenuTime;

        [FindsBy(How = How.Id, Using = "menu_attendance_Attendance")]
        private IWebElement MenuAttendance;

        [FindsBy(How = How.Id, Using = "menu_attendance_viewAttendanceRecord")]
        private IWebElement MenuAttendanceRecords;

        public void ProceedToEmployeeRecords()
        {
            MenuTime.Click();
            MenuAttendance.Click();
            MenuAttendanceRecords.Click();
        }

       

    }
}
