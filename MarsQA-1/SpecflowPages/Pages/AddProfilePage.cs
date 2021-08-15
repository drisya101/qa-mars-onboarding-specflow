
using MarsQA_1.SpecflowPages.Helpers.Models;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class AddProfilePage : Page
    {
        public AddProfilePage(IWebDriver _driver) : base(_driver)
        {
        }

        // All common elements
        private By EditDescriptionButton = By.CssSelector("div.content span.button");
        private By DescriptionTextBox = By.CssSelector("textarea");
        private By SaveDescriptionButton = By.CssSelector("div.ui.twelve.wide.column > button");
        private By DescriptionText = By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span");

        private By EducationButton = By.CssSelector("div.ui.top.attached.tabular.menu > a:nth-child(3)");
        private By AddNewButton = By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div");
        private By UniversityNameTextBox = By.CssSelector("div.ten.wide.field > input[type=text]");
        private By CountryDropDown = By.CssSelector("select[name='country']");
        private By TitleDropDown = By.CssSelector("select[name='title']");
        private By DegreeTextBox = By.CssSelector("input[name='degree']");
        private By YearDropDown = By.CssSelector("select[name='yearOfGraduation']");
        private By AddButton = By.CssSelector("div > input.ui.teal.button");

        private By DeleteEducationButton = By.CssSelector("div[data-tab='third'] span.button:nth-child(2)");

        private By CounrtyColumnValueLabel = By.CssSelector("div[data-tab='third'] table > tbody > tr > td:nth-child(1)");
        private By UniversityColumnValueLabel = By.CssSelector("div[data-tab='third'] table > tbody > tr > td:nth-child(2)");
        private By TitleColumnValueLabel = By.CssSelector("div[data-tab='third'] table > tbody > tr > td:nth-child(3)");
        private By DegreeColumnValueLabel = By.CssSelector("div[data-tab='third'] table > tbody > tr > td:nth-child(4)");
        private By GraduationYearColumnValueLabel = By.CssSelector("div[data-tab='third'] table > tbody > tr > td:nth-child(5)");

        
        private By AddNewLanguageButton = By.CssSelector("div[data-tab='first'] div.ui.teal.button");
        private By AddLanguageTextBox = By.CssSelector("input[name='name'] ");
        private By LanguageLevelDropDown = By.CssSelector("select[name='level']");
        private By AddLanguageButton = By.CssSelector("input[value='Add']");

        private By LanguageTextLabel = By.CssSelector("div[data-tab='first'] table > tbody > tr > td:nth-child(1)");
        private By LevelTextLabel = By.CssSelector("div[data-tab='first'] table > tbody > tr > td:nth-child(2)");

        private By DeleteLanguageButton = By.CssSelector("div[data-tab='first'] span.button:nth-child(2)");


        public void AddDescription(string description)
        {
            Click(EditDescriptionButton);
            EnterText(DescriptionTextBox, description);
            Click(SaveDescriptionButton);
        }

        public string GetDescription()
        {
            return GetText(DescriptionText);
        }

        public void AddEducationDetails(EducationDetails educationDetails)
        {
            Click(EducationButton);
            Click(AddNewButton);
            EnterText(UniversityNameTextBox, educationDetails.University);
            SelectByTextFromDropDown(CountryDropDown, educationDetails.Country);
            SelectByTextFromDropDown(TitleDropDown, educationDetails.Title);
            EnterText(DegreeTextBox, educationDetails.Degree);
            SelectByTextFromDropDown(YearDropDown, educationDetails.GraduationYear.ToString());
            Click(AddButton);
        }

        public string GetCountry()
        {
            return GetText(CounrtyColumnValueLabel);
        }

        public string GetUniversity()
        {
            return GetText(UniversityColumnValueLabel);
        }

        public string GetTitle()
        {
            return GetText(TitleColumnValueLabel);
        }

        public string GetDegree()
        {
            return GetText(DegreeColumnValueLabel);
        }

        public string GetGraduationYear()
        {
            return GetText(GraduationYearColumnValueLabel);
        }

        public void DeleteEducationDetails()
        {
            // So that next time when test runs the UI is clean
            Click(DeleteEducationButton);
        }

        public void AddLanguage(string language, string level)
        {
            Click(AddNewLanguageButton);
            EnterText(AddLanguageTextBox, language);
            SelectByTextFromDropDown(LanguageLevelDropDown, level);
            Click(AddLanguageButton);
        }

        public string GetLanguage()
        {
            return GetText(LanguageTextLabel);
        }

        public string GetLevel()
        {
            return GetText(LevelTextLabel);
        }

        public void DeleteLanguage()
        {
            // So that next time when test runs the UI is clean
            Click(DeleteLanguageButton);
        }

    }
}
