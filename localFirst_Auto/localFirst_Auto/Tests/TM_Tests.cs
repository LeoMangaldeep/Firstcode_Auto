using localFirst_Auto.Pages;
using localFirst_Auto.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace localFirst_Auto
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    { 
        [SetUp]
        public void LoginActions()
        {
        //Open new chrome browser
        driver = new ChromeDriver();

        //Loginpage object initilization & definition
        LoginPage loginPageobj = new LoginPage();
        loginPageobj.LoginActions(driver);

        //Homepage object creation & initialization
        HomePage homePageobj = new HomePage();
        homePageobj.GoToTMPage(driver);
        }

        [Test]
        public void CreteTM()
        {        
            //TMPage object creation 
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
        } 
        
        [Test]
        public void EditTM()
        {
            
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
            tmPageobj.EditTM(driver);
        }

        [Test]
        public void DeleteTM()
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
            tmPageobj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
                
        }
            
    }
}


