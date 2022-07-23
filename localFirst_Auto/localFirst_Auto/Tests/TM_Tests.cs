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
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {

        //Page object initialization
        TMPage tmPageObj = new TMPage();
        HomePage homePageObj = new HomePage();


        [Test, Order(1), Description("Create Time and Material record with valid credentials.")]
        public void CreteTM()
        {
            //Homepage initialization
            homePageObj.GoToTMPage(driver);
            //TMPage object creation 
            tmPageObj.CreateTM(driver);
        } 
        
        [Test,Order(2), Description("Edit Time and Material record with new set of datas in test 1")]
        public void EditTM()
        {
            //Homepage initialization
            homePageObj.GoToTMPage(driver);
            tmPageObj.CreateTM(driver);
            tmPageObj.EditTM(driver, "dummy","dummy","dummy");
        }

        [Test,Order(3), Description("Delete Time and Material record created in test 2.")]
        public void DeleteTM()
        {
            //Homepage initialization
            homePageObj.GoToTMPage(driver);
            tmPageObj.CreateTM(driver);
            tmPageObj.DeleteTM(driver);
        }
            
    }
}


