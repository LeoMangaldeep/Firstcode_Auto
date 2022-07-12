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
        TMPage tmPageobj = new TMPage();
        HomePage homePageobj = new HomePage();


        [Test, Order(1), Description("Create Time and Material record with valid credentials.")]
        public void CreteTM()
        {
            //Homepage initialization
            homePageobj.GoToTMPage(driver);
            //TMPage object creation 
            tmPageobj.CreateTM(driver);
        } 
        
        [Test,Order(2), Description("Edit Time and Material record with new set of datas in test 1")]
        public void EditTM()
        {
            //Homepage initialization
            homePageobj.GoToTMPage(driver);
            tmPageobj.CreateTM(driver);
            tmPageobj.EditTM(driver);
        }

        [Test,Order(3), Description("Delete Time and Material record created in test 2.")]
        public void DeleteTM()
        {
            //Homepage initialization
            homePageobj.GoToTMPage(driver);
            tmPageobj.CreateTM(driver);
            tmPageobj.DeleteTM(driver);
        }
            
    }
}


