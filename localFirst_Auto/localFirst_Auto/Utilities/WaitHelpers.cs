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
        public void WaitForElements(IWebElement driver)
        {
            var wait = new WebDriverWait((IWebDriver)driver, new TimeSpan(0, 0, 2));
        }
    }
}
