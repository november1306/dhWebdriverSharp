using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTest
{
    public static class Tools
    {

        public static void ClickAfterWait(IWebElement element)
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            wait.Until(condition: ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public static void WaitTableRefresh(By locator, String text )
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            wait.Until(condition: ExpectedConditions.TextToBePresentInElementLocated(locator, text));

        }

    }
}
