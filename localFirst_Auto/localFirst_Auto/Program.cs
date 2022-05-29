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
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            typeCodeDropdown.Click();                                  
            Thread.Sleep(1500);


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
            Thread.Sleep(1000);

            //Select gotolastpage(>|) icon

            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();                                  
            Thread.Sleep(2500);

            //Confirm the creation of new row

            IWebElement newRow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //Thread.Sleep(3500);                               
                                                              
            if (newRow.Text == "code123")
            {
                Console.WriteLine("Row created Successfully,Test Passed.");
            }
            else
            {
                Console.WriteLine("Failed to create a New Row, Test Failed.");
            }
            Thread.Sleep(1500);

            //Select Edit Element and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(3500);

            //Select Time option in typecode dropdown

            IWebElement dropDownOption = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            dropDownOption.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();
            Thread.Sleep(2500);

            //Select code element and give neew input

            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("How?");
            Thread.Sleep(2500);

            //Select description element and give neew input
            IWebElement editDescriptionTextbox= driver.FindElement(By.Id("Description");
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("Miracle");
            Thread.Sleep(2500);

            //Select price element and give new input

            //click save element

            //driver.Close(); 


        }
    }
}
