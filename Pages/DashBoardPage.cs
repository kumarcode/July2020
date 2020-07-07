using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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
            // Identfying the user management
            var Admin = driver.FindElement(By.Id("menu_admin_viewAdminModule"));
            Actions action = new Actions(driver);
            action.MoveToElement(Admin).Perform();
            action.MoveToElement(driver.FindElement(By.Id("menu_admin_UserManagement"))).Perform();
            // click on User
            driver.FindElement(By.Id("menu_admin_viewSystemUsers")).Click();

        }
    }
}
