using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OrangeHRMJune2020.Helpers;

namespace OrangeHRMJune2020
{
    public class DashBoardPage
    {
        private IWebDriver driver;

        public DashBoardPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        internal void ClickUsers()
        {
            try
            {
                // Identfying the user management
                var Admin = driver.FindElement(By.Id("menu_admin_viewAdminModule"));
                Actions action = new Actions(driver);
                action.MoveToElement(Admin).Perform();
                action.MoveToElement(driver.FindElement(By.Id("menu_admin_UserManagement"))).Perform();
                Sync.ElementIsClickable(driver, "Id", "menu_admin_viewSystemUsers", 5);
                // click on User
                driver.FindElement(By.Id("menu_admin_viewSystemUsers")).Click();
            }
            catch(Exception msg)
            {
                Assert.Fail("Test failed at Dashboard page", msg.Message);
            }


        }
    }
}
