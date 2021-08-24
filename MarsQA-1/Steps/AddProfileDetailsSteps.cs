using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Helpers.Models;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddProfileDetailsSteps
    {
        private readonly AddProfilePage _addProfilePage;
        private readonly LoginPage _loginPage;

        public AddProfileDetailsSteps(BrowserDriver browserDriver)
        {
            _addProfilePage = new AddProfilePage(browserDriver.Current);
            _loginPage = new LoginPage(browserDriver.Current);
        }

        [When(@"Seller updates the description section with new (.*)")]
        public void WhenSellerUpdatesTheDescriptionSectionWithNew(string description)
        {
            _addProfilePage.AddDescription(description);
        }

        [Then(@"Seller can view the new (.*)")]
        public void ThenSellerCanViewTheNew(string expectedDecription)
        {
            var actualDescription = _addProfilePage.GetDescription();
            Assert.AreEqual(expectedDecription, actualDescription);
            _loginPage.SignOut();
        }

        [When(@"Seller updates the education section with below details")]
        public void WhenSellerUpdatesTheEducationSectionWithBelowDetails(Table table)
        {
            EducationDetails educationDetails = table.CreateInstance<EducationDetails>();
            _addProfilePage.AddEducationDetails(educationDetails);
        }

        [Then(@"Seller can view the updated Education details match the below")]
        public void ThenSellerCanViewTheUpdatedEducationDetailsMatchTheBelow(Table table)
        {
            EducationDetails educationDetails = table.CreateInstance<EducationDetails>();
            Assert.AreEqual(educationDetails.Country, _addProfilePage.GetCountry());
            Assert.AreEqual(educationDetails.University, _addProfilePage.GetUniversity());
            Assert.AreEqual(educationDetails.Title, _addProfilePage.GetTitle());
            Assert.AreEqual(educationDetails.Degree, _addProfilePage.GetDegree());
            Assert.AreEqual(educationDetails.GraduationYear, int.Parse(_addProfilePage.GetGraduationYear()));
            _addProfilePage.DeleteEducationDetails();
            _loginPage.SignOut();
        }

        [When(@"Seller updates the language section with (.*) and (.*)")]
        public void WhenSellerUpdatesTheLanguageSectionWithAnd(string language, string level)
        {
            _addProfilePage.AddLanguage(language,level);
        }

        [Then(@"Seller can view the following language details (.*) and (.*)")]
        public void ThenSellerCanViewTheFollowingLanguageDetailsAnd(string expectedlanguage, string expectedlevel)
        {
            var actualLanguage = _addProfilePage.GetLanguage();
            Assert.AreEqual(expectedlanguage, actualLanguage);

            var actualLevel = _addProfilePage.GetLevel();
            Assert.AreEqual(expectedlevel, actualLevel);

            _addProfilePage.DeleteLanguage();

            _loginPage.SignOut();
        }


    }
}
