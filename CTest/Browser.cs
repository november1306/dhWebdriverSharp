using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTest
{
    class Browser
    {

        private static string baseUrl = "https://orangehrm-demo-6x.orangehrmlive.com/";
        private static IWebDriver webDriver = new FirefoxDriver();

        public IWebDriver WebDriver { get; set; }
        public string environmentURL { get; set; }

        public Browser(IWebDriver webDriver)
        {
            environmentURL = baseUrl;
            WebDriver = webDriver;
        }

        public static void Initialize()
        {

            Goto("");
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static string CurrentURL
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver _Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }
    }
}
