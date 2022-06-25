using localFirst_Auto.Utilities;
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
    public class TMPage

    {
        public void CreateTM(IWebDriver driver)
        {
            
            //Select Create New element in the time&material collumn
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//*[@id='container']/p/a", 5);
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

            //Example-1
            if (newRow.Text == "code123")
            {
                Assert.Pass("Row created Successfully,Test Passed.");
            }
            else
            {
                Assert.Fail("Failed to create a New Row, Test Failed.");
            }

        }

        public void EditTM(IWebDriver driver)

        {
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

            //Select code element and give new input
            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("How?");
            Thread.Sleep(2500);

            //Select description element and give new input
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("Miracle");
            Thread.Sleep(2500);

            //Select price element and give new input
            IWebElement editPriceTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            editPriceTextbox.Click();
            //Thread.Sleep(5000);

            //Manually getting inputs
            IWebElement editEditNewPrice = driver.FindElement(By.Id("Price"));
            editEditNewPrice.Clear();                        
            editPriceTextbox.Click();
            editEditNewPrice.SendKeys("33");
            Thread.Sleep(2500);

            //click save element
            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();
            Thread.Sleep(2000);


            //goToLastPage.Click();
            IWebElement editGoToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            Thread.Sleep(2000);
            editGoToLastPage.Click();
            Thread.Sleep(2000);

            //Check if edited row saved

            IWebElement updatedCodeBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]"));

            IWebElement updatedTypeShowBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[2]"));

            IWebElement updatedDescBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[3]"));

            IWebElement updatedPriceBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[4]"));


            //if (updatedCodeBox.Text == "How?" && updatedDescBox.Text == "Miracle" && updatedPriceBox.Text == "$33.00")

            //{
            //    Console.WriteLine("Updated successfully,test pass");
            //}
            //else
            //{
            //    Console.WriteLine("Update Failed,test failed");
            //}
            //Example-2
            Assert.That(updatedCodeBox.Text == "How?", "Actual code and Expected code donot match.");
        }
        public void DeleteTM(IWebDriver driver)
        {
            //Delete Last Row
            IWebElement deleteLastRow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteLastRow.Click();
            IAlert oKMessage = driver.SwitchTo().Alert();
            oKMessage.Accept();
        }
    }

}