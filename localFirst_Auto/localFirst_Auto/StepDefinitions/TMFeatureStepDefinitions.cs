using localFirst_Auto.Pages;
using localFirst_Auto.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace localFirst_Auto.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I Logged into turnup portal sucessfully\.")]
        public void ILoggedIntoTurnupPortalSucessfully_()
        {
            //Open new chrome browser 
            driver = new ChromeDriver();
            //Loginpage object initilization & definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(driver);
        }

        [When(@"I navigate in to time and material page\.")]
        public void INavigateInToTimeAndMaterialPage()
        {
            //Homepage initialization & navigate to TMpage 
            HomePage homePageobj = new HomePage();
            homePageobj.GoToTMPage(driver);
        }
        [When(@"I create new Time and material record\.")]
        public void ICreateNewTimeAndMaterialRecord()
        {
            //TMPage object Initialization & creation 
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
        }
        [Then(@"New time and material record created sucessfully")]
        public void NewTimeAndMaterialRecordCreatedSucessfully()
        {
            TMPage tmPageObj = new TMPage();
            string newCode = tmPageObj.GetNewCode(driver);
            string newTypeCode = tmPageObj.GetNewTypeCode(driver);
            string newDescription = tmPageObj.GetNewDescriptipn(driver);
            string newPrice = tmPageObj.GetNewPrice(driver);

            Assert.That(newCode == "code123", "Actual code and Expected code do Not match.");
            Assert.That(newTypeCode == "M", "Actual TypeCode and Expected TypeCode do Not match.");
            Assert.That(newDescription == "descrip123", "Actual Description and Expected Description do Not match.");
            Assert.That(newPrice == "$12.00", "Actual Price and Expected Price do Not match.");
        }

        [When(@"I updated '([^']*)', '([^']*)','([^']*)' on existing Time and material record\.")]
        public void WhenIUpdatedOnExistingTimeAndMaterialRecord_(string descriptionp0, string codep1, string pricep2)
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver, descriptionp0, codep1, pricep2);
            
        }

        [Then(@"The record should have the updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string descriptionp0, string codep1, string pricep2)
        {
            TMPage tmPageObj = new TMPage();
            string editedDiscription = tmPageObj.GetEditedDescription(driver);
            Assert.That(editedDiscription == descriptionp0, "Actual description and edited description did not match");
            string editedCode = tmPageObj.GetEditedCode(driver);
            Assert.That(editedCode == codep1, "Actual code and edited code did not match");
            string editedPrice = tmPageObj.GetEditedPrice(driver);
            Assert.That(editedPrice == pricep2, "Actual price and edited price did not match");
        }

        


    }
}
