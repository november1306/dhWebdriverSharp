using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;


namespace CTest.model
{
    public class EmployeeRecordsPage
    {
        private String StampIn;
        private String StampOut;

        [FindsBy(How = How.Id, Using = "attendance_employeeName_empName")]
        private IWebElement InputEmployeeName;

        [FindsBy(How = How.Id, Using = "attendance_date")]
        private IWebElement PickDate;

        [FindsBy(How = How.ClassName, Using = "btn-flat picker__today")]
        private IWebElement TodayDate;

        [FindsBy(How = How.Id, Using = "noncoreIframe")]
        private IWebElement FrameAttendance;

        [FindsBy(How = How.Id, Using = "attendance_date_root")]
        private IWebElement FramePickDate;

        [FindsBy(How = How.ClassName, Using = "ac_results")]
        private IWebElement FrameAcResults;
        
        [FindsBy(How = How.Id, Using = "btView")]
        private IWebElement ButtonView;

        [FindsBy(How = How.Id, Using = "btnAdd")]
        private IWebElement ButtonAdd;

        [FindsBy(How = How.Id, Using = "btnPunchInTrigger")]
        private IWebElement ButtonIn;

        [FindsBy(How = How.Id, Using = "btnPunchOutTrigger")]
        private IWebElement ButtonOut;

        [FindsBy(How = How.Id, Using = "attendance_note")]
        private IWebElement InputNote;

        [FindsBy(How = How.Id, Using = "resultTable")]
        private IWebElement ResultTable;
        



        public void AddAttendeeRecord(String EmployeeName)
        {
            Browser._Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser._Driver.SwitchTo().Frame(FrameAttendance);
            PutName(EmployeeName);
            PutDate();
            ButtonView.Click();


            Tools.ClickAfterWait(ButtonAdd);
            Tools.ClickAfterWait(InputNote);
            StampIn = DateTime.Now.ToLongTimeString();
            InputNote.SendKeys(StampIn);
            Tools.ClickAfterWait(ButtonIn);

            Tools.ClickAfterWait(ButtonAdd);
            Tools.ClickAfterWait(InputNote);
            StampOut = DateTime.Now.ToLongTimeString();
            InputNote.SendKeys(StampOut);
            Tools.ClickAfterWait(ButtonOut);
        
            

            Tools.WaitTableRefresh(By.XPath("(//table[1]/tbody/tr)[last()]"), StampIn);

            String LastRowText = ResultTable.FindElement(By.XPath("(//table[1]/tbody/tr)[last()]")).Text;
            Trace.Write(LastRowText.ToString());

            Assert.IsTrue(LastRowText.Contains(StampIn));
            Assert.IsTrue(LastRowText.Contains(StampOut));

        }

        private void PutName(String EmployeeName)
        {
            InputEmployeeName.Click();
            InputEmployeeName.SendKeys(EmployeeName);
            FrameAcResults.Click();
        }

        private void PutDate()
        {
            PickDate.Click();
            Assert.IsTrue(FramePickDate.Displayed);
            TodayDate = FramePickDate.FindElement(By.ClassName("picker__today"));
            TodayDate.Click();
        }



    }
}
