using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Page
    {
        public IWebDriver _driver;

        protected Page(IWebDriver driver) 
        {
            _driver = driver;
        }
        public void Click(By selector)
        {
            IWebElement element = WaitAndFindElement(selector);
            element.Click();
        }

        public void EnterText(By selector, string text)
        {
            IWebElement element = WaitAndFindElement(selector);
            element.Click();
            element.Clear();           
            element.SendKeys(text);
        }

        public string GetText(By selector)
        {
            IWebElement element = WaitAndFindElement(selector);
            return element.Text;

        }

        public void SelectByTextFromDropDown(By selector, string textToSelect)
        {
            IWebElement element = WaitAndFindElement(selector);
            var selectElement = new SelectElement(element);
            selectElement.SelectByText(textToSelect);

        }

        public IWebElement WaitAndFindElement(By selector)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            IWebElement webElement = wait.Until(ExpectedConditions.ElementExists(selector));
            return webElement;
        }
    }
}
