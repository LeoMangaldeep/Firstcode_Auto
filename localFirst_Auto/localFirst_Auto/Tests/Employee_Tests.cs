using localFirst_Auto.Pages;
using localFirst_Auto.Utilities;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace localFirst_Auto.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommonDriver
    {
        //Page object initialization
        HomePage homePageobj = new HomePage();
        EmployeePage employeePageobj = new EmployeePage();

        [Test]
        public void CreateEmployee()
        {
            homePageobj.GoToEmployeePage(driver);
            employeePageobj.CreateEmployee(driver);
        }
        [Test]
        public void EditEmployee()
        {
            homePageobj.GoToEmployeePage(driver);
            employeePageobj.EditEmployee(driver);
            Thread.Sleep(3000);
        }

        [Test]
        public void DeleteEmployee()
        {
            homePageobj.GoToEmployeePage(driver);
            employeePageobj.DeleteEmployee(driver);
        }
       
    }
}
