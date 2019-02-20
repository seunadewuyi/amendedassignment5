using System;
using TechTalk.SpecFlow;

namespace internship_project1
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"l navigate to giftrete url")]
        public void GivenLNavigateToGiftreteUrl()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click on login")]
        public void GivenClickOnLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter my email address ""(.*)""")]
        public void GivenEnterMyEmailAddress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter my password")]
        public void GivenEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter invalid email address")]
        public void GivenEnterInvalidEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter my valid email address \(omowunmi(.*)mum@yahoo\.com\)")]
        public void GivenEnterMyValidEmailAddressOmowunmimumYahoo_Com(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter invalid password")]
        public void GivenEnterInvalidPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i should be able togin to the site")]
        public void ThenIShouldBeAbleToginToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"i should not be able to login, an error message should be displayed")]
        public void ThenIShouldNotBeAbleToLoginAnErrorMessageShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
