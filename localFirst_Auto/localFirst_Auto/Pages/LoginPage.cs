using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace localFirst_Auto.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            //maximise window
            driver.Manage().Window.Maximize();         
            

            //launch url "horse.turnup"
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");

            try
            {
                // Select username textbox & enter valid username credentials.
                IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
                usernameTextbox.SendKeys("hari");

                // Select password textbox and enter valid credentials.
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");

                //identify the login textbox and click.
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
                Thread.Sleep(1500);
            }
            catch(Exception ex)
            {
                Assert.Fail("Turnup portal page did not launch",ex.Message );
            }

        }

    }
}
