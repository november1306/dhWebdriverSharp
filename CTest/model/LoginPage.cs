using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTest.model
{
    public class LoginPage
    {

        [FindsBy(How = How.Id, Using = "txtUsername")]
        private IWebElement loginField; 

        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "btnLogin")]
        private IWebElement loginButton;

        public void Goto()
        {
            Browser.Goto("/");
        }

        public void LogInAsUser(String login, String pass)
        {
            ClearLoginFields();
            loginField.SendKeys(login);
            passwordField.SendKeys(pass);
            loginButton.Click();
        }

        private void ClearLoginFields()
        {
            loginField.Clear();
            passwordField.Clear();
        }

    }
}
