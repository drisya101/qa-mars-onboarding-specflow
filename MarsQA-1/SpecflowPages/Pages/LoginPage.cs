using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    public class LoginPage : Page
    {
        public LoginPage(IWebDriver _driver) :base(_driver)
        {

        }
        private  By SignInButton = By.XPath("//A[@class='item'][text()='Sign In']");
        private  By EmailTextBox = By.XPath("(//INPUT[@type='text'])[2]");
        private  By PasswordTextBox = By.XPath("//INPUT[@type='password']");
        private  By LoginButtontn = By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']");
        private By SignOutButton = By.CssSelector("button.ui.green.basic.button");

        public  void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl(ConstantHelpers.Url);
        }

        public void Login(string username, string password)
        {
            Click(SignInButton);
            EnterText(EmailTextBox, username);
            EnterText(PasswordTextBox, password);
            Click(LoginButtontn);
        }

        public void SignOut()
        {
            Click(SignOutButton);
        }
    }
}