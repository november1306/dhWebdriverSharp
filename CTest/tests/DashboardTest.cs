using System;
using CTest.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CTest.tests
{
    [TestClass]
    public class DashboardTest
    {
        
        [TestInitialize]
        public void SetUp()
        {
            Browser.Initialize();
        }

        [TestMethod]
        public void Can_add_in_out__employee_records()
        {
            
            Pages.Login.Goto();
            Pages.Login.LogInAsUser("Admin", "admin123");
            Pages.Dashboard.ProceedToEmployeeRecords();
            Pages.EmployeeRecords.AddAttendeeRecord("Tacitus Tabby");
            
        }


        [TestCleanup]
        public void TearDown()
        {
            Browser.Close();
        }

    }
}
