using localFirst_Auto.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace localFirst_Auto
{
    public class TM_Tests
    {
        static void Main(string[] args)
        {
            //Open new chrome browser
            IWebDriver driver = new ChromeDriver();

            //Loginpage object initilization & definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(driver);

            //Homepage object creation & initialization
            HomePage homePageobj = new HomePage();
            homePageobj.GoToTMPage(driver);

            //TMPage object creation & initilization
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTM(driver);
            tmPageobj.EditTM(driver);
            tmPageobj.DeleteTM(driver);
            
            


        }
    }
}
