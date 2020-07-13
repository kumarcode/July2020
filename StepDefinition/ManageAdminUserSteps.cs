using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMJune2020.StepDefinition
{
    [Binding]
    public class ManageAdminUserSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I login to Orange HRM portal as an administration")]
        public void GivenILoginToOrangeHRMPortalAsAnAdministration()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }
        
        [Given(@"I navigate to systems user page")]
        public void GivenINavigateToSystemsUserPage()
        {
            var dashboardPage = new DashBoardPage(driver);
            dashboardPage.ClickUsers();
        }
        
        [Then(@"I should be able to create a new user successfully")]
        public void ThenIShouldBeAbleToCreateANewUserSuccessfully()
        {
            var systemUsersPage = new SystemUsersPage(driver);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser("Kumar");
            systemUsersPage.VerifyUser();
        }

        [Then(@"I should be able to edit an existing user successfully")]
        public void ThenIShouldBeAbleToEditAnExistingUserSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to delete an existing user successfully")]
        public void ThenIShouldBeAbleToDeleteAnExistingUserSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to create multiple '(.*)' successfully")]
        public void ThenIShouldBeAbleToCreateMultipleSuccessfully(string employeeName)
        {
            var systemUsersPage = new SystemUsersPage(driver);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser(employeeName);
            systemUsersPage.VerifyUser();
        }


    }
}
