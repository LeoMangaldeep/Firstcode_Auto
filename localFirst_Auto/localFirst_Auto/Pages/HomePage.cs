using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace localFirst_Auto.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {

            //Find Administration element & click the dropdown to select Time&Material & click
            IWebElement adminDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            Console.WriteLine("Clicked the tmoption");

        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            //Find Administration element & click the dropdown to select EmployeePage & click
            IWebElement adminDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdown.Click();
            Thread.Sleep(2500);

            IWebElement empOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]"));
            empOption.Click();
        }
    }
}
