using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localFirst_Auto.Utilities
{
    public class WaitHelpers
    {
        //Implicit wait defined with 2 seconds
        // wait for element to be clickable
        public static void WaitForElementToBeClickable(IWebDriver driver, String Locator, String LocatorId, int seconds)
        {
            //implicit wait---- [var wait = new WebDriverWait(IWebDriver driver, new TimeSpan(0, 0, 2));]

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            
            if (Locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(LocatorId)));
            }
            if (Locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(LocatorId)));
            }
            if (Locator == "CssSelectors")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(LocatorId)));
            }

        }
    }
}
