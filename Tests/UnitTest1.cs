using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace OrangeHRMJune2020
{
    [TestFixture]
    public class ManageAdminUserTestSuite
    {
        IWebDriver driver = new ChromeDriver();
       
        [SetUp]
        public void BeforeEachTest()
        {
            // Initiating the driver
            // driver = new ChromeDriver();
            // Create an instance of Login Page

            var loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }

        [TearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

        
        [Category("IntegrationTests")]
        [Test]        
        public void AddValidAdminUserTest()
        {
            var dashboardPage = new DashBoardPage(driver);
            dashboardPage.ClickUsers();

            var systemUsersPage = new SystemUsersPage(driver);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser();
            systemUsersPage.VerifyUser();
        }
       
        [Test]
        public void DeleteValidAdminUserTest()
        {
            var dashboardPage = new DashBoardPage(driver);
            dashboardPage.ClickUsers();

            var systemUsersPage = new SystemUsersPage(driver);
            //create method & logic to delte
        }

        [Test]
        [Category("UnitTests")]
        public void EditAdminUserTest()
        {
            Assert.Fail();
        }

    }
}