using internship_project1.pageobject;
using System;
using TechTalk.SpecFlow;

namespace internship_project1.step_defination
{
    [Binding]
    public class RegistrationSteps
    {
        Registrationpage registration;
        public RegistrationSteps()
        {
            registration = new Registrationpage();
        }

        [Given(@"I navigate to the Giftrete url")]
        public void GivenINavigateToTheGiftreteUrl()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        [When(@"I click Register")]
        public void WhenIClickRegister()
        {
            registration.ClickOnRegister();
        }




        [When(@"enter my Firstname")]
        public void WhenEnterMyFirstname()
        {
            registration.EnterFirstName();
        }

        [When(@"enter my Lastname")]
        public void WhenEnterMyLastname()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"enter my mobile number")]
        public void WhenEnterMyMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"enter my password")]
        public void WhenEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"enter i confirm my password")]
        public void WhenEnterIConfirmMyPassword()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"click on sign up")]
        public void WhenClickOnSignUp()
        {
            registration.ClickOnSignup();
        }

        [Then(@"the registration page is displayed")]
        public void ThenTheRegistrationPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
        [When(@"enter my email ""(.*)""")]
        public void WhenEnterMyEmail(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"enter an invalid email")]
        public void WhenEnterAnInvalidEmail()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the registration page is has an error")]
        public void ThenTheRegistrationPageIsHasAnError()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"enter my an invalid email")]
        public void WhenEnterMyAnInvalidEmail()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the registration page is not displayed and you get an error message")]
        public void ThenTheRegistrationPageIsNotDisplayedAndYouGetAnErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"enter my invalid mobile number")]
        public void WhenEnterMyInvalidMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the registration page is not displayed")]
        public void ThenTheRegistrationPageIsNotDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

    }
}

