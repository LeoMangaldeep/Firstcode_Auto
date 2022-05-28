using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace localFirst_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //launch web browser "chrome browser"
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //launch url "horse.turnup"
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");

            // Select username textbox & enter valid username credentials.
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // Select password textbox and enter valid credentials.
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //identify the login textbox and click.
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //Check if it was successfully loggedin.
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));


            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Login Successful, Test Passed");
            }
            else
            {
                Console.WriteLine("Login Failed, Test Failed");
            }

            //Find Administration element & click the dropdown to select Time&Material & click
            IWebElement adminDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminDropdown.Click();
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();

            //Select Create New element in the time&material collumn
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            

            //Select Typecode dropdown to choose time & click
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            typeCodeDropdown.Click();
            
            //IWebElement materialOption = driver.FindElement(By.Id("TypeCode_option_selected"));
            //materialOption.Click(); 

            //Find code Textbox element to enter new value
            IWebElement codeBox = driver.FindElement(By.Id("Code"));
            codeBox.SendKeys("code123");

            //Find Description Textbox element to enter new value
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("descrip123");
            

            //Find Price per unit textbox to enter new value
            IWebElement pPUTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pPUTextbox.Click();
            
            IWebElement pPUInputTextbox = driver.FindElement(By.Id("Price"));
            pPUInputTextbox.SendKeys("12");

            //Find Save element and click
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
        }
    }
}
