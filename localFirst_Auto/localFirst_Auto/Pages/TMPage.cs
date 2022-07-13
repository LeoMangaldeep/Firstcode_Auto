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
    public class TMPage : CommonDriver

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
            Thread.Sleep(1500);


            //// Example - 1
            //if (newCode.Text == "code123" && newTypeCode.Text == "M" && newDescription.Text == "descrip123" && newPrice.Text == "$12.00")
            //{
            //    Assert.Pass("Row created Successfully,Test Passed.");
            //}
            //else
            //{
            //    Assert.Fail("Failed to create a New Row, Test Failed.");
            //}
            //Console.WriteLine("Assert.pass or fail executed");
            Console.WriteLine("Creates record");

        }
        public string GetNewCode(IWebDriver driver)
        {
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return newCode.Text;
        }
        public string GetNewTypeCode(IWebDriver driver)
        {
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return newTypeCode.Text;
        }
        public string GetNewDescriptipn(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return newDescription.Text;
        }
        public string GetNewPrice(IWebDriver driver)
        {
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return newPrice.Text;
        }

        public void EditTM(IWebDriver driver, string description, string code, string price)

        {
            Thread.Sleep(3500);
            //Select gotolastpage(>|) icon
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPage.Click();                                   

            Console.WriteLine("Before clicking the edit button");
            //Select Edit Element and click
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Thread.Sleep(3500);                                 //*[@id="tmsGrid"]/div[3]/table/tbody/tr[6]/td[5]/a[1]
            editButton.Click();
            Thread.Sleep(3500);

            Console.WriteLine("editButton clicked");

            //Select Time option in typecode dropdown
            IWebElement dropDownOption = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            dropDownOption.Click();
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeOption.Click();
            Thread.Sleep(2500);

            Console.WriteLine("edit dropdown clicked");

            //Select code element and give new input
            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys(code);
            Thread.Sleep(2500);

            Console.WriteLine("edit editcode clicked");

            //Select description element and give new input
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys(description);
            Thread.Sleep(2500);

            Console.WriteLine("edit descriptiontextbox clicked");

            //Select price element and give new input
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span"));
                                                                    //*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span
            priceTextbox.Click();

            Console.WriteLine("editprice textbox clicked");
            //Thread.Sleep(5000);
            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPrice.Clear();
            Thread.Sleep(2500);
            priceTextbox.Click();
            editPrice.SendKeys(price);
            Thread.Sleep(2500);

            Console.WriteLine("editeditnewprice clicked");

            //click save element
            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();
            Thread.Sleep(2000);

            Console.WriteLine("editeditednewprice clicked");


            //goToLastPage.Click();
            IWebElement editGoToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            Thread.Sleep(2000);
            editGoToLastPage.Click();
            Thread.Sleep(2000);

            Console.WriteLine("editgotolastpage clicked");

            //Check if edited row saved

            IWebElement updatedCodeBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]"));

            IWebElement updatedTypeShowBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[2]"));

            IWebElement updatedDescBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[3]"));

            IWebElement updatedPriceBox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[4]"));
                                                                                                       

            //Assert.That(updatedCodeBox.Text == "How?", "Actual code and Expected code donot match.");
            //Assert.That(updatedTypeShowBox.Text == "T", "Actual Type and Expected Type donot match.");
            //Assert.That(updatedDescBox.Text == "Miracle", "Actual description and Expected description donot match.");
            //Assert.That(updatedPriceBox.Text == "$33.00", "Actual price and Expected price donot match.");

        }
        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescription.Text;
        }
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCode.Text;
        }
        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return editedPrice.Text;
        }


        public void DeleteTM(IWebDriver driver)
        {
            //Delete Last Row
            IWebElement deleteLastRow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteLastRow.Click();
            IAlert oKMessage = driver.SwitchTo().Alert();
            oKMessage.Accept();
        }

        public static implicit operator string(TMPage v)
        {
            throw new NotImplementedException();
        }
    }

}