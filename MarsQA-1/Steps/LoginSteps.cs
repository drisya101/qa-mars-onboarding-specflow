using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class LoginSteps
    {        
        private readonly LoginPage _loginPage;

        public LoginSteps(BrowserDriver browserDriver)
        {
            _loginPage = new LoginPage(browserDriver.Current);
        }

        [Given(@"I am logged in as a Seller")]
        public void GivenIAmLoggedInAsASeller()
        {
            _loginPage.NavigateToLoginPage();
            _loginPage.Login("bdddemo@gmail.com", "bdd.demo123");
        }      
    }
}
